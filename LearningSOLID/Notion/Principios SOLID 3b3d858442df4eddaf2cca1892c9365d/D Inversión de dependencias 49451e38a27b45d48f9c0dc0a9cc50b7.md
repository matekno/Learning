# D: Inversión de dependencias

<aside>
💡 A. Las clases de alto nivel no deberían depender de las clases de bajo nivel. Ambas deberían depender de las abstracciones.
B. Las abstracciones no deberían depender de los detalles. Los detalles deberían depender de las abstracciones.

</aside>

Una clase de alto nivel vendría siendo la lógica de nuestro software, su objetivo, sus organizaciones, etc.

Unos módulos de bajo nivel, vendría siendo cosas más específicas del funcionamiento, por ejemplo, una conexión a una base de datos. Hoy es con EF, pero lo podríamos cambiar a Dapper y seguiría funcionando todo el código.

[El contexto](D%20Inversio%CC%81n%20de%20dependencias%2049451e38a27b45d48f9c0dc0a9cc50b7/El%20contexto%20a90d91f430734cc6b3b35a2ea014f686.md)

[El problema](D%20Inversio%CC%81n%20de%20dependencias%2049451e38a27b45d48f9c0dc0a9cc50b7/El%20problema%20bea001637b264412ac283c2ef619b573.md)

[La solución: Invertir las dependencias](D%20Inversio%CC%81n%20de%20dependencias%2049451e38a27b45d48f9c0dc0a9cc50b7/La%20solucio%CC%81n%20Invertir%20las%20dependencias%2032e2aa3d3a0b41ce9b6d62a263df425a.md)