# Stored Procedures

```csharp
public static void Delete()
        {
            //! PARA HACER UN DELETE
            TOKEN zTOKEN = db.TOKEN.Find(27);// buscamos la entidad a eliminar
            db.TOKEN.Remove(zTOKEN);// removemos
            db.SaveChanges();// guardamos
        }
```