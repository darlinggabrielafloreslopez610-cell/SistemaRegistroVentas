import sys
import os
import csv
import matplotlib.pyplot as plt


if len(sys.argv) > 1:
    ruta_csv = sys.argv[1]
else:
    ruta_csv = os.path.join(os.path.dirname(__file__), "Resultados", "datos_productos.csv")

productos = []


try:
    with open(ruta_csv, "r", encoding="utf-8-sig", newline="") as archivo:
        lector = csv.DictReader(archivo)
        
        for fila in lector:
            producto = {
                "codigo": fila["Codigo"],
                "nombre": fila["Nombre"],
                "precio": float(fila["Precio"]) if fila["Precio"] else 0.0,
                "stock": int(fila["Stock"]) if fila["Stock"] else 0
            }
            productos.append(producto)
            
    print(f"Productos cargados correctamente: {len(productos)}")
except Exception as e:
    print(f"Error al leer el archivo CSV: {e}")