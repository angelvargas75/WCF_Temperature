<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClienteWebWCFConverTemps.Default" Async="true" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Conversión de Temperatura</title>
    <!-- CSS de Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- JavaScript de Bootstrap -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
    <!-- Meta para responsividad -->
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
        body {
            background-color: #2d2d2d;
            color: white;
            font-family: Arial, sans-serif;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            margin: 30px;
        }

        .container {
            display: flex;
            flex-wrap: wrap;
            width: 100%;
            max-width: 900px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
            border-radius: 8px;
            overflow: hidden;
            margin: 20px;
            background-color: #3c3c3c;
            padding: 20px;
        }

        .left-panel, .right-panel {
            flex: 1;
            padding: 20px;
            min-width: 300px;
            text-align: center;
        }

        .left-panel {
            background-color: #FF6F61;
        }

        .left-panel img {
            max-width: 100%;
            height: auto;
            margin-bottom: 20px;
            border-radius: 8px;
        }

        .right-panel {
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
        }

        .btn {
            margin-top: 10px;
            width: 100%;
        }

         .btn-orange {
            background-color: #FF6F61;
            color: white;
            border: none;
        }

        .btn-orange:hover {
            background-color: #e55d54;
        }

        .radio-container {
            display: flex;
            justify-content: center;
            margin: 20px 0;
            gap: 10px;
        }

        .radio-container input {
            accent-color: #FF6F61;
        }


        @media (max-width: 768px) {
            .container {
                flex-direction: column;
                max-width: 100%;
            }

            .left-panel, .right-panel {
                width: 100%;
            }
        }

        @media (max-width: 576px) {
            .container {
                padding: 0;
                box-shadow: none;
            }

            .left-panel img {
                margin-bottom: 15px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container">
            <!-- Panel izquierdo -->
            <div class="left-panel">
                <h2>Convierte temperaturas</h2>
                <p>Entre Celsius y Fahrenheit</p>
                <img src="Images/Thermometer.png" alt="Icono de termómetro" />
                <p>¡Es fácil y rápido!</p>
            </div>
            <!-- Panel derecho -->
            <div class="right-panel">
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <div class="mb-3 text-center">
                            <label for="txtGrados" class="form-label">Grados:</label>
                            <asp:TextBox ID="txtGrados" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="radio-container">
                            <div>
                                <asp:RadioButton ID="boConvCF" runat="server" GroupName="g1" Text="Celsius a Fahrenheit" />
                            </div>
                            <div>
                                <asp:RadioButton ID="boConvFC" runat="server" GroupName="g1" Text="Fahrenheit a Celsius" />
                            </div>
                        </div>
                        <div class="d-flex flex-column w-100 text-center">
                            <asp:Button ID="btnConvertir" runat="server" Text="Convertir" OnClick="btnConvertir_Click" CssClass="btn btn-orange" />
                            <asp:Button ID="btnDetalles" runat="server" OnClick="btnDetalles_Click" Text="Ver Detalles" CssClass="btn btn-secondary" />
                            <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" CssClass="btn btn-danger" />
                        </div>
                        <asp:Label ID="lblError" runat="server" Text="" CssClass="text-danger d-block mt-2 text-center"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </form>
</body>
</html>
