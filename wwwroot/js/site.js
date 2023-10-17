function MostrarDetalleTemporadas(Id_Serie, Nombre){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarDetalleTemporadas',
            data: { IdSerie: Id_Serie },
            success:
            function(response){
                $("#Title").html("<strong><u>Temporadas de la serie: </strong></u>" + Nombre)
                let cuerpo="";
                response.forEach(item => {
                    cuerpo += item.tituloTemporada + "<br>";
                });
                $("#cuerpomodal").html(cuerpo);
            }
        }
    );
}
function MostrarDetalleActores(Id_Serie, Nombre){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarDetalleActor',
            data: { IdSerie: Id_Serie },
            success:
            function(response){
                $("#Title").html("Actores de la serie" )
                let cuerpo=""; 
                let num=1;
                response.forEach(item => {
                    cuerpo += "<strong><u>Actor "+num+":</strong></u> "+item.nombre + "<br>";
                    num = num + 1;
                });
                $("#cuerpomodal").html(cuerpo);
            }
        }
    );
}
function MostrarDetalleSerie(Id_Serie, Nombre, AñoInicio,Sinopsis){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarDetalleActor',
            data: { IdSerie: Id_Serie },
            success:
            function(response){
            $("#Title").html("<strong>Más Información de la serie </strong>");
            $("#cuerpomodal").html(" <strong> <u> Nombre de la Serie:</u></strong> "+Nombre +"<br><strong><u>Año Inicio: :</u></strong>"+AñoInicio + "<br><strong><u>Sinopsis::</u></strong> "+Sinopsis)
            }
        }
    );
}