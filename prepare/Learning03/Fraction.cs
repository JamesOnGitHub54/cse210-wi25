using System;

public class Fraction{
    private int top_number;
    private int bottom_number;

    public Fraction(){
        top_number = 1;
        bottom_number = 1;

    }

    public Fraction(int whole_number){
        top_number = whole_number;
        bottom_number = 1;
    }
    
    public Fraction(int top, int bottom){
        top_number = top;
        bottom_number = bottom;
    }




}