using MediatorDesignPattern;

ConcreteMediator concreteMediator = new ();

ConcreteColleagueA concreteColleagueA = new (concreteMediator);
ConcreteColleagueB concreteColleagueB = new (concreteMediator);

concreteMediator.ConcreteColleagueA = concreteColleagueA;
concreteMediator.ConcreteColleagueB = concreteColleagueB;

concreteColleagueA.Send("Hi, how are you?");
concreteColleagueB.Send("Fine, thanks and you?");
concreteColleagueA.Send("I am fine too.");

// Wait for user
Console.ReadKey();