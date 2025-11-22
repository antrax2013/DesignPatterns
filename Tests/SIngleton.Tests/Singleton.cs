using NFluent;

namespace Singleton.Tests;

public class Tests
{

    [Test]
    public void Quand_On_Demande_2_Instances_Alors_Elles_Pointes_Bien_Vers_La_Meme_Reference()
    {
        // When
        MemoryCache cache1 = MemoryCache.GetInstance();
        MemoryCache cache2 = MemoryCache.GetInstance();

        // Then
        Check.That(cache1).IsSameReferenceAs(cache2);
    }

    [Test]
    public void Quand_J_Ajoute_Un_Objet_En_Cache_Dans_Une_Instance_Alors_Je_Le_Retrouve_Et_Il_A_La_Valeur_Attendu()
    {
        // Given
        MemoryCache cache = MemoryCache.GetInstance();

        cache.Add("Name", "Toto");

        // When
        string? name = cache.Get("Name")?.ToString();

        // Then
        Check.That(name).IsEqualTo("Toto");
    }

    [Test]
    public void Quand_J_Ajoute_Un_Objet_En_Cache_Dans_Une_Instance_Alors_Je_Le_Retrouve_Dans_L_Autre_Instance_Et_Il_A_La_Valeur_Attendu()
    {
        // Given
        MemoryCache cache1 = MemoryCache.GetInstance();
        MemoryCache cache2 = MemoryCache.GetInstance();

        cache1.Add("Name", "Toto");

        // When
        string? name = cache2.Get("Name")?.ToString();

        // Then
        Check.That(name).IsEqualTo("Toto");
    }

    [Test]
    public void Quand_Je_Supprime_Un_Objet_En_Cache_Dans_Une_Instance_Et_Que_J_Essaye_De_La_Relire_Alors_J_Obitiens_Null()
    {
        // Given
        MemoryCache cache = MemoryCache.GetInstance();

        cache.Add("Name", "Toto");
        cache.Remove("Name");

        // When
        string? name = cache.Get("Name")?.ToString();

        // Then
        Check.That(name).IsNull();
    }

    [Test]
    public void Quand_Je_Supprime_Un_Objet_En_Cache_Dans_Une_Instance_Et_Que_J_Essaye_De_La_Relire_Dans_Une_Autre_Instance_Alors_J_Obitiens_Null()
    {
        // Given
        // Given
        MemoryCache cache1 = MemoryCache.GetInstance();
        MemoryCache cache2 = MemoryCache.GetInstance();


        cache1.Add("Name", "Toto");
        cache1.Remove("Name");

        // When
        string? name = cache2.Get("Name")?.ToString();

        // Then
        Check.That(name).IsNull();
    }
}
