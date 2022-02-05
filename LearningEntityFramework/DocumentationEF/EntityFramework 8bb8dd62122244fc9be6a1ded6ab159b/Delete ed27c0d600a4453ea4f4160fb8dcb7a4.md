# Delete

```csharp
public static IEnumerable<List<CHAIN>> Sp_Chains()
        {
            var temp = db.Database.SqlQuery<List<CHAIN>>("sp_PRUEBA").ToList();
            Console.WriteLine(temp.GetType());
            return temp;
        }
```