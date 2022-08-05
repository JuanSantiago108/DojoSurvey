#pragma warning disable CS8618 
namespace DojoSurvey.Models;

public class User
{
    public string Name { get ; set ;}
    public string DojoLocation { get ; set ;}
    public string FavoriteLanguage { get ; set ;}
    public string Comment { get ; set ;}

    public string InfoCard()
    {
        return $"Name: {Name} ,Dojo Location: {DojoLocation} ,FavoriteLanguage: {FavoriteLanguage} ,Comment: {Comment} ";
    }
}