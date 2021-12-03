using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventCode : MonoBehaviour
{
   

    string filePath = "Assets/Resources/input2.txt";
    public bool test = false;
     int numberofIncrements = 0;
    public List<int> listOfNumbers = new List<int>();
    public enum Direction { forward, down,up};
    [System.Serializable]
    public struct Commnads
    {
        public int number;
        public Direction direction;
    }
    public List<Commnads> listOfCommnads = new List<Commnads>();
    // Start is called before the first frame update
    void Start()
    {
       
         //import a text file .txt
      
            //print all the lines
         if (test)
         {
             filePath = "Assets/Resources/input_base.txt";
         }
         else
         {
             filePath = "Assets/Resources/input2.txt";
         }
   string[] lines = System.IO.File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] words = line.Split(' ');
            print(words[0]+" "+words[1]);
        
              listOfCommnads.Add(new Commnads { number = int.Parse(words[1]), direction = (Direction)System.Enum.Parse( typeof(Direction), words[0])});
            
        }
        Exercise3(listOfCommnads);
        //int[]Numeros = new int[lines.Length];
/*
 for (int i = 0; i < lines.Length; i++)
        {
            Numeros[i] = int.Parse(lines[i]);

        }
       int[] NumerosBase={199,200,208,210,200,207,240,269,260,263};
        Exercise2(Numeros);
    */


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Exercise1(){
          string[] lines = System.IO.File.ReadAllLines(filePath);
  print(lines.Length);
           //count if the number is bigger than the next number
            for (int i = 0; i < lines.Length; i++)
            {
                if(i+1<lines.Length)
                {
                 
                 //print number and next number
                    
                    if(int.Parse(lines[i])<int.Parse(lines[i+1]))
                    {
                        numberofIncrements+=1;
                    }
                    print(int.Parse(lines[i]) + " " + int.Parse(lines[i + 1])+" "+numberofIncrements);
                }
                
            }
            //print the number of increments
            Debug.Log(numberofIncrements);
    }
    void Exercise2(int[]Numeros){
     
     print(Numeros.Length);
        int count=0;
        for (int i = 0; i < Numeros.Length; i++)
        {
            //add the number to the list each 3 numbers
         
                
         
               
                    if(i+2<Numeros.Length){
int sum=  Numeros[i]+Numeros[i+1]+Numeros[i+2];
               
               
                    listOfNumbers.Add(sum);
                    }
                         
                   
        }
        //print the list of numbers
        Debug.Log(listOfNumbers.Count);
       
        for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if(i+1<listOfNumbers.Count)
                {
                 
                 //print number and next number
                    
                    if(listOfNumbers[i]<listOfNumbers[i+1])
                    {
                        numberofIncrements+=1;
                    }
                   
                }
                
            }
            print("THe number of incremenst: "+numberofIncrements);


    }

void Exercise3(List<Commnads> listOfCommnads){
/*
    down X increases your aim by X units.
up X decreases your aim by X units.
forward X does two things:
It increases your horizontal position by X units.
It increases your depth by your aim multiplied by X.*/
   int horizontal=0;
    int depth=0;
    int aim=0;
    for (int i = 0; i < listOfCommnads.Count; i++)  {

        if(listOfCommnads[i].direction==Direction.down){
            //depth+=listOfCommnads[i].number;
            aim+=listOfCommnads[i].number;

        }
        if(listOfCommnads[i].direction==Direction.up){
            //depth-=listOfCommnads[i].number;
            aim-=listOfCommnads[i].number;
        }
        if(listOfCommnads[i].direction==Direction.forward){
            horizontal+=listOfCommnads[i].number;
            depth=horizontal*aim;
        }
    print("The horizontal distance is: "+horizontal+" and the depth is: "+aim+" and the total is: "+(Mathf.Abs(horizontal)*Mathf.Abs(depth)));

    }


}


     
    
}
