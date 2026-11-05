class Nodo:
    def __init__(self, producto):
        self.producto = producto
        self.izquierda = None
        self.derecha = None

class ArbolBinario:
    def __init__(self):
        self.raiz = None

    def insertar(self, producto):
        nuevo_nodo = Nodo(producto)
        if self.raiz is None:
            self.raiz = nuevo_nodo
        else:
            actual = self.raiz
            while True:
                if producto["stock"] < actual.producto["stock"]:
                    if actual.izquierda is None:
                        actual.izquierda = nuevo_nodo
                        break
                    actual = actual.izquierda
                else:
                    if actual.derecha is None:
                        actual.derecha = nuevo_nodo
                        break
                    actual = actual.derecha

    def inorden(self, nodo, lista_resultado):
        if nodo is not None:
            self.inorden(nodo.izquierda, lista_resultado)
            lista_resultado.append(nodo.producto)
            self.inorden(nodo.derecha, lista_resultado)


arbol = ArbolBinario()
for prod in productos:
    arbol.insertar(prod)

productos_ordenados = []
arbol.inorden(arbol.raiz, productos_ordenados)

print("\n========== ARBOL BINARIO DE PRODUCTOS ==========")

print("\nProductos insertados en el arbol:", len(productos))

print("\n========== RECORRIDO INORDEN ==========")
print("Productos ordenados por cantidad de stock:\n")

for producto in productos_ordenados:
    print(
        f"Codigo: {producto['codigo']} | "
        f"Nombre: {producto['nombre']} | "
        f"Stock: {producto['stock']}"
    )

print("\n========== PRODUCTOS ORDENADOS POR STOCK ==========")


if productos_ordenados:
    nombres = [p["nombre"] for p in productos_ordenados]
    stocks = [p["stock"] for p in productos_ordenados]

    plt.figure(figsize=(8, 5))
    plt.bar(nombres, stocks, color='skyblue', edgecolor='black')
    plt.xlabel("Productos")
    plt.ylabel("Stock (Existencias)")
    plt.title("Análisis de Stock por Producto - Pulpería Mimí")
    plt.xticks(rotation=45)
    plt.tight_layout()
    
    print("\nMostrando la gráfica de análisis...")
    plt.show()
else:
    print("\nNo hay productos para graficar.")

input("\nPresiona Enter para cerrar el análisis...")