﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenVueling.Infrastructure.Repository {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResourceMessage {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceMessage() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExamenVueling.Infrastructure.Repository.ResourceMessage", typeof(ResourceMessage).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a &quot;Valor no puede ser null.&quot;.
        /// </summary>
        internal static string ArgumentNullException {
            get {
                return ResourceManager.GetString("ArgumentNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El guardado se anuló porque la validación de los valores de propiedad de la entidad falló..
        /// </summary>
        internal static string DbEntityValidationException {
            get {
                return ResourceManager.GetString("DbEntityValidationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Un comando de base de datos no afectó el número esperado de filas. Esto generalmente indica una violación de concurrencia optimista; es decir, se ha cambiado una fila en la base de datos desde que se consultó..
        /// </summary>
        internal static string DbUpdateConcurrencyException {
            get {
                return ResourceManager.GetString("DbUpdateConcurrencyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Ocurrió un error al enviar actualizaciones a la base de datos..
        /// </summary>
        internal static string DbUpdateException {
            get {
                return ResourceManager.GetString("DbUpdateException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se produjo algún error al intentar procesar entidades en el contexto antes o después de enviar comandos a la base de datos..
        /// </summary>
        internal static string InvalidOperationException {
            get {
                return ResourceManager.GetString("InvalidOperationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Se intentó utilizar un comportamiento no compatible, como la ejecución simultánea de varios comandos asincrónicos en la misma instancia de contexto..
        /// </summary>
        internal static string NotSupportedException {
            get {
                return ResourceManager.GetString("NotSupportedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El contexto o la conexión han sido eliminados..
        /// </summary>
        internal static string ObjectDisposedException {
            get {
                return ResourceManager.GetString("ObjectDisposedException", resourceCulture);
            }
        }
    }
}
