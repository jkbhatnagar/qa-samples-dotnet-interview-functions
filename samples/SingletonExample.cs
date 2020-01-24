public class SingletonExample  
{  
    //lazy construction  
    //the class variable is null if no instance is created  
  
   private static SingletonExample uniqueInstance = null;  
     
   private SingletonExample(){  
     //private constructor  
  }  
  
  //lazy construction of the instance  
  public static SingletonExample  getInstance()  
  {  
      if(uniqueInstance == null){  
         uniqueInstance = new SingletonExample();  
      }  
  
      return uniqueInstance ;  
  }  
}  
