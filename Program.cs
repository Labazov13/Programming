class Animal { 
    string kindOfAnimal;
    string name;
// удалили ветку blackList
    public int sum(int a,int b){
        int result=a+b;
        Console.WriteLine(result);
        return result;
        
    }

    public void sayHello(string name){
        Console.WriteLine("Hello "+name);
    }
    
    public static void Main() {
        Animal Barsik = new Animal();
        Barsik.sayHello("Petya");
        Barsik.kindOfAnimal = "Cat";
        Barsik.name = "Кот Барсик";
        Barsik.sum(2,4);
        Console.WriteLine("кот "+ Barsik.kindOfAnimal+ " кличка "+ Barsik.name);
    }
    

}
