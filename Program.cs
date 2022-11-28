class Animal { 
    string kindOfAnimal;
    string name;

    public void sayHello(string name){
        Console.WriteLine("Hello "+name);
    }
    
    public static void Main() {
        Animal Barsik = new Animal();
        Barsik.sayHello("Petya");
        Barsik.kindOfAnimal = "Cat";
        Barsik.name = "Кот Барсик";
        
        Console.WriteLine("кот "+ Barsik.kindOfAnimal+ " кличка "+ Barsik.name);
    }
    

}
