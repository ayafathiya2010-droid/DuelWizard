//using System;

//public class wizard
//{
//    public string namawizard;
//    public int energy;
//    public int damage;

//    public wizard(string nama_wizard, int damage)
//    {
//        this.namawizard = nama_wizard;
//        this.energy = 100;
//        this.damage = damage;
//    }


//    public void nyawa(wizard enemy)
//    {
//        enemy.energy -= damage;

//        if (enemy.energy < 0)
//            enemy.energy = 0;

//        Console.WriteLine($"{namawizard} menyerang {enemy.namawizard}!");
//        Console.WriteLine($"Sisa energi {enemy.namawizard}: {enemy.energy}");
//        Console.WriteLine();
//    }

//    public void heal()
//    {
//        energy += 5;
//        if (energy >= 100) ;

//        Console.Write($"{namawizard} menambah heal +++++");
//        Console.Write($"heal {namawizard} saat ini adalah: {energy}");

//    }

//    public void ShowStats()
//    {
//        Console.WriteLine($"{namawizard} mempunyai energi: {energy}");
//    }
//}

//class Program
//{

//    static void Main(string[] args)
//    {
//        wizard wizard1 = new wizard("Patpat", 20);
//        wizard wizard2 = new wizard("Grumppy", 25);

//        wizard1.ShowStats();
//        wizard2.ShowStats();
//        Console.WriteLine();

//        wizard1.nyawa(wizard2);
//        wizard2.nyawa(wizard1);
//        wizard1.nyawa(wizard2);

//        wizard1.ShowStats();
//        wizard2.ShowStats();
//        Console.WriteLine();

//        wizard1.heal();
//        wizard2.heal();


//    }




//}


//revisi

using System.Net.Http.Metrics;
using System.Runtime.InteropServices;

wizard WizardA = new wizard("Pat", 10);
wizard WizardB = new wizard("Grumpy", 20);

Console.WriteLine("Permainan dimulaaiii!!\n");
Console.WriteLine("Statistik awal");
WizardA.ShowStats();
WizardB.ShowStats();

WizardA.Attack(WizardB);
WizardB.Attack(WizardA);
WizardA.Attack(WizardB);
WizardB.Attack(WizardA);

Console.WriteLine("Permainan selesai.....\n");
Console.WriteLine("Statistik akhir");
WizardA.ShowStats();
WizardB.ShowStats();

public class wizard
{
    public string Name;
    public int Energy;
    public int Damage;

    public wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }

    public void ShowStats()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Energy: {Energy}\n");
    }

    public void Attack(wizard enemy)
    {
        enemy.Energy -= Damage;
        Console.WriteLine($"{Name} menyerang {enemy.Energy}");
        Console.WriteLine($"Sisa eneri {enemy.Name}: {enemy.Energy}\n");
    }

}

