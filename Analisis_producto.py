# 3. Estructura de Árbol Binario
class Nodo:
    def __init__(self, producto):
        self.producto = producto
        self.izquierda = None
        self.derecha = None

class ArbolBinario:
    def __init__(self):
        self.raiz = None
