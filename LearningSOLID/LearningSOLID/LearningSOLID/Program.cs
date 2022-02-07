using LearningSOLID.Liskov;
using LearningSOLID.DependencyInversion;
using Monitor = LearningSOLID.DependencyInversion.Monitor;

#region Liskov

T t = new S(); // cumple con el principio de sutitucion de liskov
Console.WriteLine(t.GetName());
t = new S2(); // como cumple con el principio de sutitucion de liskov, podemos hacer esto, ya que S2 es hija de T.
Console.WriteLine(t.GetName());

#endregion

const string origin = @"D:\proyectoTrackCrictos\Learning\LearningSOLID\posts.json";
const string dbPath = @"D:\proyectoTrackCrictos\Learning\LearningSOLID\db.json";
IInfo info = new InfoByRequest(origin); // inyectar la dependencia

#region bad-dependency-inversion

var monitor = new Monitor(origin);
await monitor.Show();

// esto en teoria funciona, pero el problema es que no es escalable en lo absoluto
// y ahora, cuando camnbian los requerimientos, por ejemplo, que en lugar de guardar en una db se guarda en un endpoint
// tenemos que hacer una clase nueva    
FileDB fileDb = new FileDB(dbPath, origin);
await fileDb.Save();

#endregion

#region good-dependency-inversion

var monitorGood = new MonitorGood(origin, info); // mandamos a info dentro en el constructor
await monitorGood.Show();

var fileDbGood = new FileDBGood(dbPath, origin, info);
await fileDbGood.Save();

#endregion
