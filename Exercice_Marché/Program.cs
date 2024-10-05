// Exo_Marché

// Mes variables

string[] monPanier = new string[5];
bool continueWhile = true;
int position = 0;

// Mes fonctions
bool AjouterUnFruit(string UnFruit)
{
    if (monPanier.Count() <= 5)
    {
        if (monPanier.Contains(UnFruit))
        {
            Console.WriteLine("Ce fruit est déjà dans votre panier");
            return continueWhile = true;

        }
        else
        {
            monPanier[position] = UnFruit;
            position++;
            Console.WriteLine($"Le fruit {UnFruit} a été ajouté dans votre panier");
            return continueWhile = true;
        }
    }

    else
    {
        Console.WriteLine("Le panier est plein ! Merci de le vider avant d'ajouter un fruit ");
        return continueWhile = true;
    }
}

bool RetirerUnFruit(string deletedfruit)
{
    bool fruitTrouve = false;
    for (int i = 0; i<=4; i++)
    {
        if (monPanier[i] == deletedfruit)
        {
            monPanier[i] = null;
            Console.WriteLine($"{deletedfruit} a été retiré du panier.");
            fruitTrouve = true;
            return continueWhile = true;
            break;
        }   
    }
    
    if (!fruitTrouve)
    {
        Console.WriteLine($"Le fruit '{deletedfruit}' n'est pas dans votre panier");
    }
    
    return continueWhile = true;
}

// Mon code principal

Console.WriteLine("Voilà le jeu du marché ! ");

do 
{
    Console.WriteLine("Que voulez-vous faire : \n" +
                      "1 : Ajoutez un fruit \n" +
                      "2 : Retirer un fruit \n" +
                      "3 : Afficher le panier \n" +
                      "4 : Rechercher un fruit \n" +
                      "5 : Quittez le programme \n");
    
    int choix = int.Parse(Console.ReadLine());

    switch (choix)
    {
        case 1:
        {
            Console.WriteLine("Tapez le nom du fruit que vous voulez ajouter au panier: ");
            string fruit = Console.ReadLine();
            AjouterUnFruit(fruit);
            break;
        }

        case 2:
            Console.WriteLine("Tapez le nom du fruit que vous voulez retirer du panier: ");
            string retrait = Console.ReadLine();
            RetirerUnFruit(retrait);
            break;

        case 3:
            for(int i =0; i<=4; i++)
            {
                Console.WriteLine(monPanier[i]);
            }
            break;

        case 4:
            // A terminer 
            break;

        case 5:
            Console.WriteLine("Au revoir ! ");
            continueWhile = false;
            break;

        default:
            Console.WriteLine("Choix invalide, veuillez réessayer.");
            break;
    }
}   
while (continueWhile == true);        