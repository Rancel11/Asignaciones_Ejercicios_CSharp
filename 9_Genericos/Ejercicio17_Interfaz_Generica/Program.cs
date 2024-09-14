
public interface IContenedor<T>
{
    void Agregar(T objeto);
    T Obtener();
}


public class Caja<T> : IContenedor<T>
{
    private T objeto;

    public void Agregar(T objeto)
    {
        this.objeto = objeto;
    }

    public T Obtener()
    {
        return objeto;
    }
}
