namespace LearningInterfaces.Interfaces;
public interface IBebida
{
    string Presentacion { get; set; }
    string Marca { get; set; }
    
    int Capacidad { get; set; }
    float Precio { get; set; }
    
    void Llenar(int nuevaCantidad);
    string Mostrar();

}