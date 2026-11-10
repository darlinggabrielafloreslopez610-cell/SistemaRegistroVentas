# 4. Generar la gráfica de barras con Matplotlib
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
