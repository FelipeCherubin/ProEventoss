import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { error } from 'selenium-webdriver';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any = [];
  public eventosFiltros: any = [];
  widthImg: number = 50;
  marginImg: number = 2;
  ocultarImagem: boolean = false;
  private _filtroLista: string = '';

  public get filtroLista(): string{
    return this._filtroLista;
  }

  public set filtroLista(value: string){
    this._filtroLista = value;
    this.eventosFiltros = this.filtroLista ? this.filtrarEventos(this.filtroLista.toLocaleLowerCase()) : this.eventos;
  }

  filtrarEventos(filtrarPor: string): any{
    return this.eventos.filter(
      evento => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

  monstraImagem(): void{
    this.ocultarImagem = !this.ocultarImagem;
  }

  public getEventos(): void{
    this.http.get('https://localhost:5001/api/eventos').subscribe(
      response => {
        this.eventos = response;
        this.eventosFiltros = this.eventos
      },
      error => console.log(error)
    );
  }
}
