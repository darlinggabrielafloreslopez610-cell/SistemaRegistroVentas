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