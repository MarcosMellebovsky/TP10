﻿function MostrarSerie(IdS) 
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerDetalleSeries',
            data: {IdSerie : IdS},
            success:
            function(response)
        {
            $("#Name").html(response.nombre);
            $("#ImagenSerie").attr("src", response.imagenSerie);
            $("#AñoInicio").html("Año de inicio: " + response.añoInicio);
            $("#Sinopsis").html("Sinopsis: " +response.sinopsis);
            TemporadaFunc();
            ActoresFunc();
        }
        }
        
    )
    
}

function MostrarActores(IdS) 
{
    let Actor = "";
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerDetalleActores',
            data: {IdSerie : IdS},
            success:
            function(response)
        {
            response.forEach(element => {
            Actor += "Nombre del Actor/actriz: " + element.nombre + "<br>" + "<br>" 
           });

           $("#Actores").html(Actor);
           InfoSerieFunc();
           TemporadaFunc();
        }
        }
        
    )
    
}

function MostrarTemporadas(IdS) 
{
    let Tempo = "";
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerDetalleTemporada',
            data: {IdSerie : IdS},
            success:
            function(response)
        {
            hello.forEach(element => {
            Tempo += "Numero de Temporada: " + element.numeroTemporada + "<br>";
            Tempo += "Titulo de Temporada: " + element.tituloTemporada + "<br>" + "<br>";
           });

           $("#Temporadas").html(Tempo);
           
        }
        }
        
    )
    
}
function InfoSerieFunc() {
    $("AñoInicio").html("");
    $("Sinopsis").html("");
}
function TemporadaFunc() {
    $("Temporadas").html("");
}
function ActoresFunc() {
    $("Actores").html("");
}
