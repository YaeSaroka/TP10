function MostrarDetalleTemporadas(Id_Serie, Nombre, Numero){
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/MostrarDetalleTemporadas',
            data: { IdSerie: Id_Serie },
            success:
            function(response){
                $("#Title").html("Temporadas de la serie: " + Nombre)
                var cuerpo="";
                response.forEach(item => {
                    cuerpo += `${item.Numero} <br>`;
                });
            }
        }
    );
}