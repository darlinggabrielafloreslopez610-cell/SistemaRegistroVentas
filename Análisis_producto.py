# Construir y llenar el árbol
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