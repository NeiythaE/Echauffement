namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Je m'appelle France Martin");
        Console.WriteLine("Jeux préfèré : Destiny 2.");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Quel est ton nom ?");
        string nom = Console.ReadLine();
        Console.WriteLine("Et quel age a tu ?");
        int age = Convert.ToInt32(Console.ReadLine());
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        if (age < 18)
        {
            Console.WriteLine("tu est mineur");
        }
        else
        {
            Console.WriteLine("tu est majeur");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("combien d'euro a tu ?");
        Double argent = Convert.ToDouble(Console.ReadLine());
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("4 choix d'arme s'offrent désormais a vous");
        Console.WriteLine("revolver : 250 euro");
        Console.WriteLine("couteau : 100 euro");
        Console.WriteLine("pistolet mitrailleur : 500 euro");
        Console.WriteLine("fisil d'assaut : 600 euro");
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("coisissez une arme 1: revolver 2: couteau 3: pistolet mitrailleur 4: fusil d'assaut");
        int choix = Convert.ToInt32(Console.ReadLine());
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if (age < 18)
        {
            Console.WriteLine("vous n'avez pas l'age légal pour acheté cet objet");
        }
        else 
        {
            if (choix == 1)
            {
                Console.WriteLine("vous avez choisis le revolver");
            }
            else
            {
                if (argent - 250 < 0)
                {
                    Console.WriteLine("vous n'avez malheureusement pas assez d'argent pour acheter cet article");
                }
                else
                {
                    Console.WriteLine("merci pour votre achat");
                }
            }
            if (choix == 2)
                {
                Console.WriteLine("vous avez choisis le couteau");
                if (argent - 100 < 0)
                {
                    Console.WriteLine("vous n'avez malheureusement pas assez d'argent pour acheter cet article");
                }
                else
                {
                    Console.WriteLine("merci pour votre achat");
                }
            }
            if (choix == 3)
                {
                Console.WriteLine("vous avez choisis le pistolet mitrailleur");
                if (argent - 500 < 0)
                {
                    Console.WriteLine("vous n'avez malheureusement pas assez d'argent pour acheter cet article");
                }
                else
                {
                    Console.WriteLine("merci pour votre achat");
                }
            }
            if (choix == 4)
            {
                Console.WriteLine("vous avez choisis le fisil d'assaut");
                if (argent - 600 < 0)
                {
                   Console.WriteLine("vous n'avez malheureusement pas assez d'argent pour acheter cet article");
                }
                else
                {
                    Console.WriteLine("merci pour votre achat");
                }
            }
            }
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}