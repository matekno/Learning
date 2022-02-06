using LearningSOLID.Liskov;

#region Liskov

T t = new S(); // cumple con el principio de sutitucion de liskov
Console.WriteLine(t.GetName());
t = new S2(); // como cumple con el principio de sutitucion de liskov, podemos hacer esto, ya que S2 es hija de T.
Console.WriteLine(t.GetName());

#endregion