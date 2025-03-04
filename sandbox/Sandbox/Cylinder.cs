class Cylinder
{
    private double hieght;
    private Circle circle;
    
    public Cylinder(double hieght, Circle circle)
    {
        this.hieght = hieght;
        this.circle = circle;
    }
    public double GetVolume()
    { 
        return hieght * circle.GetArea();
    }
    
    public void SetHeight(double newHieght)
    {
       hieght = newHieght; 
    }
    
    public void SetCircle(Circle newCircle)
    {
        circle = newCircle;
    }

}