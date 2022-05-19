import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  URL : string = 'http://localhost:5000/api/eventos'
  public eventos : any =[];
  public eventoFiltrados: any = [];
  widthImage = 150;
  marginImage =2;
  showImage = true;
  private _filterList: string = '';


  public get filterList(): string{
    return this._filterList;
  }
  public set filterList(value: string){
    this._filterList = value;
    this.eventoFiltrados = this.filterList ? this.filterEventos(this.filterList) : this.eventos;
  }


  filterEventos(filterPor: string): any{
    filterPor = filterPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: { tema:string; local:string; }) => 
        evento.tema.toLocaleLowerCase().indexOf(filterPor) !== -1 ||
        evento.local.toLocaleLowerCase().indexOf(filterPor) !== -1

    )
  }

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getEventos();
  }
  hidenImage(){
    this.showImage = !this.showImage;
  }

  public getEventos(): void {
    this.http.get(this.URL).subscribe(
      response => {
        this.eventos = response,
        this.eventoFiltrados = this.eventos
      },
      error => console.log(error)
    );
  }

}
