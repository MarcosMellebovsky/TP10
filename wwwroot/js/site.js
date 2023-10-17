function MostrarSerie(IdS) 
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
            
        }
        }
        
    )
    
}

function MostrarActores(IdS) 
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerDetalleActores',
            data: {IdSerie : IdS},
            success:
            function(hola)
        {
           for (let index = 0; index < hola.length; index++) {
            
            
           }

        }
        }
        
    )
    
}

function MostrarTemporadas(IdS) 
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/VerDetalleTemporada',
            data: {IdSerie : IdS},
            success:
            function(hello)
        {
            let element = "";
            for (let index = 0; index < hello.length; index++) {
                
                element = element + hello[index];
                $(element).html(hello[index]);
               }
               

        }
        }
        
    )
    
}
