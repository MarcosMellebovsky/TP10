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
            let element = "";
            for (let index = 0; index < response.length; index++) {
                
                element = element + response[index];
                $(element).html(response[index]);
               }
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
            url: '/Home/VerDetalleSeries',
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
            url: '/Home/VerDetalleSeries',
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
