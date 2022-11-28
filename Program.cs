class Animal { 
    string kindOfAnimal;
    string name;
    
    public static void Main() {
        Animal Barsik = new Animal();
        Barsik.kindOfAnimal = "Cat";
        Barsik.name = "Кот Барсик";
        
        Console.WriteLine("кот "+ Barsik.kindOfAnimal+ " кличка "+ Barsik.name);
    }
    

}
