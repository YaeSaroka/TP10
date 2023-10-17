using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
namespace TP10.Models;
public static class BD
{
    private static string ConnectionString { get; set; } = @"Server=.;DataBase=BDSeries;Trusted_Connection=True;";
    public static Series CargarSerie(int IdSerie)
    {
        Series serie_ = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Series WHERE IdSerie = @pIdSerie";
            serie_ = db.QueryFirstOrDefault<Series>(sql, new { pIdSerie = IdSerie });
        }
        return serie_;
    }
    
    public static List <Series> CargarTodasSeries()
    {
        List<Series> series_;
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Series";
            series_ = db.Query<Series>(sql).ToList();
        }
        return series_;
    }
    public static List <Actores> CargarActores(int IdSerie)
    {
        List <Actores> actores_ = new List<Actores>();
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Actores WHERE IdSerie = @pIdSerie";
            actores_ = db.Query<Actores>(sql, new { pIdSerie = IdSerie}).ToList();
        }
        return actores_;
    }
    public static List <Temporadas> CargarTemporada(int IdSerie)
    {
        List <Temporadas> temporadas_ = new List<Temporadas>();
        using (SqlConnection db = new SqlConnection(ConnectionString))
        {
            string sql = "SELECT * FROM Temporadas WHERE IdSerie = @pIdSerie";
            temporadas_ = db.Query<Temporadas>(sql, new { pIdSerie = IdSerie }).ToList();
        }
        return temporadas_;
    }
}