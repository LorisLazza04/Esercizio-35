AlberoBinarioIntero padre;
AlberoBinarioIntero sx;
AlberoBinarioIntero dx;
AlberoBinarioIntero radice = new AlberoBinarioIntero("+");
dx = new AlberoBinarioIntero(5);
dx.inserisciDx(new AlberoBinarioIntero(2));
padre = new AlberoBinarioIntero("-", null, dx);
radice.inserisciDx(padre);

radice.isDegenere();
class AlberoBinarioIntero
{
    int val;
    public int Val { get => val; set => val = value; }
    string valString;
    public string ValString { get => valString; set => valString = value; }
    AlberoBinarioIntero sx;
    public AlberoBinarioIntero Sx { get => sx; set => sx = value; }
    AlberoBinarioIntero dx;
    public AlberoBinarioIntero Dx { get => dx; set => dx = value; }
    public AlberoBinarioIntero(int val, AlberoBinarioIntero sx, AlberoBinarioIntero dx)
    {
        this.val = val;
        this.sx = sx;
        this.dx = dx;
    }
    public AlberoBinarioIntero(string valString, AlberoBinarioIntero sx, AlberoBinarioIntero dx)
    {
        this.valString = valString;
        this.sx = sx;
        this.dx = dx;
    }
    public AlberoBinarioIntero(int val)
    {
        this.val = val;
    }
    public AlberoBinarioIntero(string valString)
    {
        this.valString = valString;
    }
    public void inserisciSx(AlberoBinarioIntero a)
    {
        this.sx = a;
    }
    public void inserisciDx(AlberoBinarioIntero a)
    {
        this.dx = a;
    }
    public void isDegenere()
    {
        Stack<AlberoBinarioIntero> albero = new Stack<AlberoBinarioIntero>();
        AlberoBinarioIntero tmp = this;
        albero.Push(tmp);
        bool DegSx = false;
        bool DegDx = false;
        bool generico = false;

        while (albero.Count != 0)
        {
            tmp = albero.Pop();
            if (tmp.dx != null)
            {
                DegDx = true;
                albero.Push(tmp.dx);
            }
            if (tmp.sx != null)
            {
                DegSx = true;
                albero.Push(tmp.sx);
            }
            if (tmp.sx != null && tmp.dx != null)
            {
                generico = true;
            }
        }
        if (generico == true)
        {
            Console.WriteLine("L'albero è degenere generico");
        }
        else if (DegDx == true && DegSx == false)
        {
            Console.WriteLine("L'albero è degenere destro");
        }
        else if (DegSx == true && DegDx == false)
        {
            Console.WriteLine("L'albero è degenere sinistro");
        }
        else
        {
            Console.WriteLine("L'albero è degenere generico");
        }
    }
}
