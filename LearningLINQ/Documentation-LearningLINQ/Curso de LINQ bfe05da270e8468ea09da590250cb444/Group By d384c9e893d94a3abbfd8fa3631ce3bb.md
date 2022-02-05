# Group By

[https://stackoverflow.com/questions/16522645/linq-groupby-sum-and-count](https://stackoverflow.com/questions/16522645/linq-groupby-sum-and-count)

usamos el Group By para el mismo fin que en SQL.

Devuelve un objeto de tipo `IGrouping` que tiene una llave y el valor directamente.

A diferencia de SQL, puede o no tener alguna funcion aggregate, como `sum`, `avg`, etc.

En el siguiente caso, hacemos un nuevo grupo llamado `g` que refiere a todos los tokens agrupados por nombre. Es decir, si tenemos dos veces al token ETH, lo junta en uno solo, y suma sus balances.

```csharp
// item1: balance,
// item2: cgTicker,
// item3: chain,
// item4: address

var result = (from token in finalBalances
                      where token.Item4 == wallet
                      group token by token.Item2
                      into g
                      select new TokensPerWallet
                      {
                          Token = g.First().Item2,
                          Balance = g.Sum(a => a.Item1),
                          Address = g.First().Item4,
                          Chain = g.First().Item3
                      }).ToList();
```