# Edit

```csharp
public static void Edit()
        {
            //! PARA HACER UN EDIT
            WALLET_X_TOKEN tempWalletBalancer = db.WALLET_X_TOKEN.First(d => d.FK_WALLET == 1 && d.FK_TOKEN == 3);// levantamos la entidad
            var balanceAnterior = tempWalletBalancer.TOKEN_BALANCE;// si queremos podemos guardar en el back algun dato anterior
            tempWalletBalancer.TOKEN_BALANCE = 2;// editamos

            // guardamos los cambios
            db.Entry(tempWalletBalancer).State = EntityState.Modified;// agregamos esta linea en un edit
            db.SaveChanges();// guardamos
        }
```