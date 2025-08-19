import openpyxl


def reportes(TABLA_DATOS: object):
    """Convierte el DataTable de .NET a tuplas de Python para procesamiento"""
    # Obtener nombres de columnas
    columnas = [col.ColumnName for col in TABLA_DATOS.Columns]
    
    # Convertir filas a tuplas
    datos = []
    for i in range(TABLA_DATOS.Rows.Count):
        fila = TABLA_DATOS.Rows[i]
        tupla_fila = tuple(fila[col] for col in columnas)
        datos.append(tupla_fila)
    
    # Ejemplo de uso con las tuplas
    print("\n" + "#"*50)
    print("Reporte generado exitosamente")
    print("#"*50)
    print(f"Total de registros: {len(datos)}")
    print("\nMuestra de datos:")
    
    # Mostrar encabezados
    print(" | ".join(columnas))
    print("-" * 80)
    
    fila_virtual = f""""""
    # Mostrar primeras 5 filas
    for i in range(len(datos)):
        fila_virtual += (" | ".join(str(valor) for valor in datos[i]))
        
    return fila_virtual