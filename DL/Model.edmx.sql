
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/25/2018 15:05:38
-- Generated from EDMX file: C:\Users\Javier\source\repos\ZimplexERP\DL\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ERP_SITEM];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AfectadoEmpresaCliente_Empleados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AfectadoEmpresaCliente] DROP CONSTRAINT [FK_AfectadoEmpresaCliente_Empleados];
GO
IF OBJECT_ID(N'[dbo].[FK_AfectadoEmpresaCliente_EmpresasClientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AfectadoEmpresaCliente] DROP CONSTRAINT [FK_AfectadoEmpresaCliente_EmpresasClientes];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[FK_AspNetUserRoles_AspNetRoles_RoleId]', 'F') IS NOT NULL
    ALTER TABLE [ERP_SITEMModelStoreContainer].[NetUsersRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[FK_AspNetUserRoles_AspNetUsers_UserId]', 'F') IS NOT NULL
    ALTER TABLE [ERP_SITEMModelStoreContainer].[NetUsersRoles] DROP CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoriaEmpleado_Sindicatos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CategoriaEmpleado] DROP CONSTRAINT [FK_CategoriaEmpleado_Sindicatos];
GO
IF OBJECT_ID(N'[dbo].[FK_Empleados_EmpresasClientes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Empleados_EmpresasClientes];
GO
IF OBJECT_ID(N'[dbo].[FK_Empleados_EstadoCivil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Empleados_EstadoCivil];
GO
IF OBJECT_ID(N'[dbo].[FK_Empleados_Localidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Empleados_Localidades];
GO
IF OBJECT_ID(N'[dbo].[FK_Empleados_Nacionalidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Empleados_Nacionalidades];
GO
IF OBJECT_ID(N'[dbo].[FK_Empleados_ObraSocial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Empleados_ObraSocial];
GO
IF OBJECT_ID(N'[dbo].[FK_Empleados_Sexos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Empleados_Sexos];
GO
IF OBJECT_ID(N'[dbo].[FK_Empleados_Zonas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Empleados_Zonas];
GO
IF OBJECT_ID(N'[dbo].[FK_Mantenimiento_ActividadMantenimiento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mantenimiento] DROP CONSTRAINT [FK_Mantenimiento_ActividadMantenimiento];
GO
IF OBJECT_ID(N'[dbo].[FK_Mantenimiento_Empleados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mantenimiento] DROP CONSTRAINT [FK_Mantenimiento_Empleados];
GO
IF OBJECT_ID(N'[dbo].[FK_Mantenimiento_Talleres]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mantenimiento] DROP CONSTRAINT [FK_Mantenimiento_Talleres];
GO
IF OBJECT_ID(N'[dbo].[FK_Mantenimiento_Vehiculos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Mantenimiento] DROP CONSTRAINT [FK_Mantenimiento_Vehiculos];
GO
IF OBJECT_ID(N'[dbo].[FK_ModelosVehiculos_MarcasVehiculos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModelosVehiculos] DROP CONSTRAINT [FK_ModelosVehiculos_MarcasVehiculos];
GO
IF OBJECT_ID(N'[dbo].[FK_Pagos_Retenciones]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pagos] DROP CONSTRAINT [FK_Pagos_Retenciones];
GO
IF OBJECT_ID(N'[dbo].[FK_Personas_EstadoCivil]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas] DROP CONSTRAINT [FK_Personas_EstadoCivil];
GO
IF OBJECT_ID(N'[dbo].[FK_Personas_Localidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas] DROP CONSTRAINT [FK_Personas_Localidades];
GO
IF OBJECT_ID(N'[dbo].[FK_Personas_Nacionalidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas] DROP CONSTRAINT [FK_Personas_Nacionalidades];
GO
IF OBJECT_ID(N'[dbo].[FK_Personas_ObraSocial]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Personas] DROP CONSTRAINT [FK_Personas_ObraSocial];
GO
IF OBJECT_ID(N'[dbo].[FK_Proveedores_AspNetUsers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proveedores] DROP CONSTRAINT [FK_Proveedores_AspNetUsers];
GO
IF OBJECT_ID(N'[dbo].[FK_Proveedores_Proveedores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proveedores] DROP CONSTRAINT [FK_Proveedores_Proveedores];
GO
IF OBJECT_ID(N'[dbo].[FK_Proveedores_RubroProveedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proveedores] DROP CONSTRAINT [FK_Proveedores_RubroProveedor];
GO
IF OBJECT_ID(N'[dbo].[FK_Referencias_Personas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Referencias] DROP CONSTRAINT [FK_Referencias_Personas];
GO
IF OBJECT_ID(N'[dbo].[FK_SolicitudesEmpleo_Personas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SolicitudesEmpleo] DROP CONSTRAINT [FK_SolicitudesEmpleo_Personas];
GO
IF OBJECT_ID(N'[dbo].[FK_SubMenus_Menus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SubMenus] DROP CONSTRAINT [FK_SubMenus_Menus];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Almacen_Table_Zonas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Almacenes] DROP CONSTRAINT [FK_Table_Almacen_Table_Zonas];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Articulos_Table_Categoria]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulos] DROP CONSTRAINT [FK_Table_Articulos_Table_Categoria];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Articulos_Table_Ubicacion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articulos] DROP CONSTRAINT [FK_Table_Articulos_Table_Ubicacion];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Comprobante_Table_CentroCosto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobantes] DROP CONSTRAINT [FK_Table_Comprobante_Table_CentroCosto];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Comprobante_Table_CondicionCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobantes] DROP CONSTRAINT [FK_Table_Comprobante_Table_CondicionCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Comprobante_Table_Contable]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobantes] DROP CONSTRAINT [FK_Table_Comprobante_Table_Contable];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Comprobante_Table_Estados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobantes] DROP CONSTRAINT [FK_Table_Comprobante_Table_Estados];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Comprobante_Table_TipoComprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobantes] DROP CONSTRAINT [FK_Table_Comprobante_Table_TipoComprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Comprobante_Table_TipoFactura]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comprobantes] DROP CONSTRAINT [FK_Table_Comprobante_Table_TipoFactura];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_DetalleMediosPago_Table_Banco]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleMediosPagos] DROP CONSTRAINT [FK_Table_DetalleMediosPago_Table_Banco];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_DetalleMediosPago_Table_MedioPago]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleMediosPagos] DROP CONSTRAINT [FK_Table_DetalleMediosPago_Table_MedioPago];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_DetalleMediosPago_Table_Pagos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleMediosPagos] DROP CONSTRAINT [FK_Table_DetalleMediosPago_Table_Pagos];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_DetallePago_Table_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetallesPago] DROP CONSTRAINT [FK_Table_DetallePago_Table_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_DetallePago_Table_Pagos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetallesPago] DROP CONSTRAINT [FK_Table_DetallePago_Table_Pagos];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_DetalleProveedor_ProductorSeguro_Table_ProductorSeguro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleProveedor_ProductorSeguro] DROP CONSTRAINT [FK_Table_DetalleProveedor_ProductorSeguro_Table_ProductorSeguro];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_DetalleProveedor_ProductorSeguro_Table_Proveedores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalleProveedor_ProductorSeguro] DROP CONSTRAINT [FK_Table_DetalleProveedor_ProductorSeguro_Table_Proveedores];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_DetallesComprobanteArticulos_Table_Articulos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetallesComprobanteArticulos] DROP CONSTRAINT [FK_Table_DetallesComprobanteArticulos_Table_Articulos];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_DetallesComprobanteArticulos_Table_Comprobante]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetallesComprobanteArticulos] DROP CONSTRAINT [FK_Table_DetallesComprobanteArticulos_Table_Comprobante];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Empleado_Table_CategoriaEmpleado]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Table_Empleado_Table_CategoriaEmpleado];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Empleado_Table_Departamento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Table_Empleado_Table_Departamento];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Empleado_Table_Especialidad]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Table_Empleado_Table_Especialidad];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Empleado_Table_Sindicato]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Empleados] DROP CONSTRAINT [FK_Table_Empleado_Table_Sindicato];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_IngresoMateriales_Table_Almacen]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[IngresoMateriales] DROP CONSTRAINT [FK_Table_IngresoMateriales_Table_Almacen];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_IngresoMateriales_Table_Articulos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[IngresoMateriales] DROP CONSTRAINT [FK_Table_IngresoMateriales_Table_Articulos];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Proveedores_Table_Localidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proveedores] DROP CONSTRAINT [FK_Table_Proveedores_Table_Localidades];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Proveedores_Table_Provincias]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proveedores] DROP CONSTRAINT [FK_Table_Proveedores_Table_Provincias];
GO
IF OBJECT_ID(N'[dbo].[FK_Talleres_Localidades]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Talleres] DROP CONSTRAINT [FK_Talleres_Localidades];
GO
IF OBJECT_ID(N'[dbo].[FK_Talleres_TipoTaller]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Talleres] DROP CONSTRAINT [FK_Talleres_TipoTaller];
GO
IF OBJECT_ID(N'[dbo].[FK_Users_Profiles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_Users_Profiles];
GO
IF OBJECT_ID(N'[dbo].[FK_Vehiculos_Combustibles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehiculos] DROP CONSTRAINT [FK_Vehiculos_Combustibles];
GO
IF OBJECT_ID(N'[dbo].[FK_Vehiculos_Empleados]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehiculos] DROP CONSTRAINT [FK_Vehiculos_Empleados];
GO
IF OBJECT_ID(N'[dbo].[FK_Vehiculos_MarcasVehiculos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehiculos] DROP CONSTRAINT [FK_Vehiculos_MarcasVehiculos];
GO
IF OBJECT_ID(N'[dbo].[FK_Vehiculos_ModelosVehiculos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehiculos] DROP CONSTRAINT [FK_Vehiculos_ModelosVehiculos];
GO
IF OBJECT_ID(N'[dbo].[FK_Vehiculos_PolizasSeguro]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehiculos] DROP CONSTRAINT [FK_Vehiculos_PolizasSeguro];
GO
IF OBJECT_ID(N'[dbo].[FK_Vehiculos_Vehiculos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehiculos] DROP CONSTRAINT [FK_Vehiculos_Vehiculos];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ActividadMantenimiento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActividadMantenimiento];
GO
IF OBJECT_ID(N'[dbo].[AfectadoEmpresaCliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AfectadoEmpresaCliente];
GO
IF OBJECT_ID(N'[dbo].[Almacenes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Almacenes];
GO
IF OBJECT_ID(N'[dbo].[Articulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Articulos];
GO
IF OBJECT_ID(N'[dbo].[Bancos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bancos];
GO
IF OBJECT_ID(N'[dbo].[CategoriaEmpleado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CategoriaEmpleado];
GO
IF OBJECT_ID(N'[dbo].[Categorias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categorias];
GO
IF OBJECT_ID(N'[dbo].[CentroCostos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CentroCostos];
GO
IF OBJECT_ID(N'[dbo].[Combustibles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Combustibles];
GO
IF OBJECT_ID(N'[dbo].[Comprobantes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comprobantes];
GO
IF OBJECT_ID(N'[dbo].[CondicionesCompra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CondicionesCompra];
GO
IF OBJECT_ID(N'[dbo].[Contable]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contable];
GO
IF OBJECT_ID(N'[dbo].[CuentaCorriente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CuentaCorriente];
GO
IF OBJECT_ID(N'[dbo].[Departamentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Departamentos];
GO
IF OBJECT_ID(N'[dbo].[DetalleMantenimientoRepuestos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleMantenimientoRepuestos];
GO
IF OBJECT_ID(N'[dbo].[DetalleMediosPagos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleMediosPagos];
GO
IF OBJECT_ID(N'[dbo].[DetalleProveedor_ProductorSeguro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalleProveedor_ProductorSeguro];
GO
IF OBJECT_ID(N'[dbo].[DetallesComprobanteArticulos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetallesComprobanteArticulos];
GO
IF OBJECT_ID(N'[dbo].[DetallesPago]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetallesPago];
GO
IF OBJECT_ID(N'[dbo].[Empleados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empleados];
GO
IF OBJECT_ID(N'[dbo].[Empresas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empresas];
GO
IF OBJECT_ID(N'[dbo].[EmpresasClientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmpresasClientes];
GO
IF OBJECT_ID(N'[dbo].[Especialidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Especialidades];
GO
IF OBJECT_ID(N'[dbo].[EstadoCivil]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstadoCivil];
GO
IF OBJECT_ID(N'[dbo].[Estados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estados];
GO
IF OBJECT_ID(N'[dbo].[EstudiosRealizados]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EstudiosRealizados];
GO
IF OBJECT_ID(N'[dbo].[IngresoMateriales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[IngresoMateriales];
GO
IF OBJECT_ID(N'[dbo].[Localidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Localidades];
GO
IF OBJECT_ID(N'[dbo].[Mantenimiento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mantenimiento];
GO
IF OBJECT_ID(N'[dbo].[MarcasVehiculos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MarcasVehiculos];
GO
IF OBJECT_ID(N'[dbo].[MediosPago]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MediosPago];
GO
IF OBJECT_ID(N'[dbo].[Menus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menus];
GO
IF OBJECT_ID(N'[dbo].[ModelosVehiculos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModelosVehiculos];
GO
IF OBJECT_ID(N'[dbo].[Nacionalidades]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Nacionalidades];
GO
IF OBJECT_ID(N'[dbo].[NetRoles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NetRoles];
GO
IF OBJECT_ID(N'[dbo].[NetUser]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NetUser];
GO
IF OBJECT_ID(N'[dbo].[NetUserLogin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NetUserLogin];
GO
IF OBJECT_ID(N'[dbo].[ObraSocial]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ObraSocial];
GO
IF OBJECT_ID(N'[dbo].[PadronRgsRet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PadronRgsRet];
GO
IF OBJECT_ID(N'[dbo].[Pagos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pagos];
GO
IF OBJECT_ID(N'[dbo].[PermissionMenus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PermissionMenus];
GO
IF OBJECT_ID(N'[dbo].[Personas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personas];
GO
IF OBJECT_ID(N'[dbo].[PolizasSeguro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PolizasSeguro];
GO
IF OBJECT_ID(N'[dbo].[ProductoresSeguro]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductoresSeguro];
GO
IF OBJECT_ID(N'[dbo].[Profiles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Profiles];
GO
IF OBJECT_ID(N'[dbo].[Proveedores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proveedores];
GO
IF OBJECT_ID(N'[dbo].[Provincias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Provincias];
GO
IF OBJECT_ID(N'[dbo].[Referencias]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Referencias];
GO
IF OBJECT_ID(N'[dbo].[RegistroConducirBool]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RegistroConducirBool];
GO
IF OBJECT_ID(N'[dbo].[Retenciones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Retenciones];
GO
IF OBJECT_ID(N'[dbo].[RubroProveedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RubroProveedor];
GO
IF OBJECT_ID(N'[dbo].[Sexos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sexos];
GO
IF OBJECT_ID(N'[dbo].[Sindicatos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sindicatos];
GO
IF OBJECT_ID(N'[dbo].[SolicitudesEmpleo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SolicitudesEmpleo];
GO
IF OBJECT_ID(N'[dbo].[SubMenus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SubMenus];
GO
IF OBJECT_ID(N'[dbo].[TablaDivisorCalculo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TablaDivisorCalculo];
GO
IF OBJECT_ID(N'[dbo].[Talleres]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Talleres];
GO
IF OBJECT_ID(N'[dbo].[TiposComprobante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TiposComprobante];
GO
IF OBJECT_ID(N'[dbo].[TiposFactura]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TiposFactura];
GO
IF OBJECT_ID(N'[dbo].[TipoTaller]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoTaller];
GO
IF OBJECT_ID(N'[dbo].[Ubicacion]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ubicacion];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Vehiculos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehiculos];
GO
IF OBJECT_ID(N'[dbo].[Vencimientos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vencimientos];
GO
IF OBJECT_ID(N'[dbo].[Zonas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zonas];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[NetUsersRoles]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[NetUsersRoles];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[Choferes]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[Choferes];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[CuentasCorrientes]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[CuentasCorrientes];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[DatosEmpleadosActivos]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[DatosEmpleadosActivos];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[DetallePago]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[DetallePago];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[DetallesSolicitudesEmpleo]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[DetallesSolicitudesEmpleo];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[ListaTalleresMecanicos]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[ListaTalleresMecanicos];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[NominaCV]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[NominaCV];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[NominaTelecentro]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[NominaTelecentro];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[Solicitudesempleos]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[Solicitudesempleos];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[View_DetalleArticulo]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[View_DetalleArticulo];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[View_DetalleArticuloComprobante]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[View_DetalleArticuloComprobante];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[View_ListaEmpleados]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[View_ListaEmpleados];
GO
IF OBJECT_ID(N'[ERP_SITEMModelStoreContainer].[View_Proveedores]', 'U') IS NOT NULL
    DROP TABLE [ERP_SITEMModelStoreContainer].[View_Proveedores];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ActividadMantenimiento'
CREATE TABLE [dbo].[ActividadMantenimiento] (
    [IDActividadMantenimiento] int IDENTITY(1,1) NOT NULL,
    [Detalle] varchar(150)  NULL
);
GO

-- Creating table 'AfectadoEmpresaCliente'
CREATE TABLE [dbo].[AfectadoEmpresaCliente] (
    [IDAfectadoEmpresaCliente] int IDENTITY(1,1) NOT NULL,
    [IdEmpresaCliente] int  NULL,
    [IdEmpleado] int  NULL
);
GO

-- Creating table 'Almacenes'
CREATE TABLE [dbo].[Almacenes] (
    [IdAlmacen] int IDENTITY(1,1) NOT NULL,
    [FechaAlta] datetime  NULL,
    [Nombre] varchar(50)  NULL,
    [Codigo] nchar(10)  NULL,
    [IdEncargado] int  NULL,
    [IDZona] int  NULL
);
GO

-- Creating table 'Articulos'
CREATE TABLE [dbo].[Articulos] (
    [IDArticulo] int IDENTITY(1,1) NOT NULL,
    [IDCategoria] int  NOT NULL,
    [IdAlmacen] int  NULL,
    [IdUbicacion] int  NULL,
    [Nombre] varchar(100)  NULL,
    [Descripcion] varchar(100)  NULL,
    [Codigo] varchar(50)  NULL,
    [Stock] float  NULL,
    [Iva] float  NULL
);
GO

-- Creating table 'Bancos'
CREATE TABLE [dbo].[Bancos] (
    [IdBanco] int  NOT NULL,
    [Nombre] varchar(50)  NULL,
    [Sucursal] varchar(50)  NULL,
    [TipoCuenta] varchar(50)  NULL,
    [Numero] varchar(50)  NULL,
    [CBU] varchar(50)  NULL
);
GO

-- Creating table 'CategoriaEmpleado'
CREATE TABLE [dbo].[CategoriaEmpleado] (
    [idCategoriaEmpleado] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NULL,
    [IDSindicato] int  NULL
);
GO

-- Creating table 'Categorias'
CREATE TABLE [dbo].[Categorias] (
    [IDCategoria] int  NOT NULL,
    [Categoria] varchar(50)  NULL
);
GO

-- Creating table 'CentroCostos'
CREATE TABLE [dbo].[CentroCostos] (
    [IdCentroCosto] int IDENTITY(1,1) NOT NULL,
    [CentroCosto] varchar(50)  NULL
);
GO

-- Creating table 'Combustibles'
CREATE TABLE [dbo].[Combustibles] (
    [IDCombustible] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NULL
);
GO

-- Creating table 'Comprobantes'
CREATE TABLE [dbo].[Comprobantes] (
    [IdComprobante] int IDENTITY(1,1) NOT NULL,
    [Sucursal] varchar(4)  NULL,
    [NoFactura] varchar(8)  NULL,
    [Fecha] datetime  NULL,
    [FechaVencimiento] datetime  NULL,
    [IdTipoComprobante] int  NULL,
    [IdCentroCosto] int  NULL,
    [IdTipoFactura] int  NULL,
    [Importe] float  NULL,
    [Contable] int  NULL,
    [IdProveedor] int  NULL,
    [IdCondicionCompra] int  NULL,
    [IdEstado] int  NULL,
    [IIBB] float  NULL,
    [Retenciones] float  NULL,
    [ConceptosNograbado] float  NULL,
    [PercepcionIva] float  NULL,
    [ImporteNeto] float  NULL
);
GO

-- Creating table 'CondicionesCompra'
CREATE TABLE [dbo].[CondicionesCompra] (
    [IdCondicionCompra] int  NOT NULL,
    [Condiciondecompra] varchar(50)  NULL
);
GO

-- Creating table 'Contable'
CREATE TABLE [dbo].[Contable] (
    [IdContable] int  NOT NULL,
    [Contable1] nchar(15)  NULL
);
GO

-- Creating table 'CuentaCorriente'
CREATE TABLE [dbo].[CuentaCorriente] (
    [IdCuentaCorriente] int IDENTITY(1,1) NOT NULL,
    [IDProveedor] int  NULL,
    [Nombre] nchar(11)  NULL,
    [Vencimiento] int  NULL,
    [Comentario] varchar(50)  NULL
);
GO

-- Creating table 'Departamentos'
CREATE TABLE [dbo].[Departamentos] (
    [IdDepartamento] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NOT NULL
);
GO

-- Creating table 'DetalleMantenimientoRepuestos'
CREATE TABLE [dbo].[DetalleMantenimientoRepuestos] (
    [IdDetalleMantenimientoRepuesto] int IDENTITY(1,1) NOT NULL,
    [IDMantenimiento] int  NULL,
    [IdRepuestos] int  NULL
);
GO

-- Creating table 'DetalleMediosPagos'
CREATE TABLE [dbo].[DetalleMediosPagos] (
    [IdDetalleMedioPago] int IDENTITY(1,1) NOT NULL,
    [IdMedioPago] int  NULL,
    [NoCheque] varchar(50)  NULL,
    [FechaVencimientoCheque] datetime  NULL,
    [IdBanco] int  NULL,
    [Importe] float  NULL,
    [IdPago] int  NULL
);
GO

-- Creating table 'DetalleProveedor_ProductorSeguro'
CREATE TABLE [dbo].[DetalleProveedor_ProductorSeguro] (
    [IdDetalleProveedor_ProductorSeguro] int IDENTITY(1,1) NOT NULL,
    [IdProveedor] int  NULL,
    [IdProductorSeguro] int  NULL
);
GO

-- Creating table 'DetallesComprobanteArticulos'
CREATE TABLE [dbo].[DetallesComprobanteArticulos] (
    [idTable_DetallesComprobanteArticulos] int IDENTITY(1,1) NOT NULL,
    [IdComprobante] int  NULL,
    [IdArticulo] int  NULL,
    [Cantidad] float  NULL,
    [Precio] float  NULL,
    [Iva] float  NULL,
    [Importe] float  NULL,
    [IvaCalculado] float  NULL
);
GO

-- Creating table 'DetallesPago'
CREATE TABLE [dbo].[DetallesPago] (
    [IdDetallePago] int IDENTITY(1,1) NOT NULL,
    [idComprobante] int  NULL,
    [IdPago] int  NULL
);
GO

-- Creating table 'Empleados'
CREATE TABLE [dbo].[Empleados] (
    [IDEmpleado] int IDENTITY(1,1) NOT NULL,
    [Orden] int  NULL,
    [ImagenPerfil] varbinary(max)  NULL,
    [Activo] bit  NULL,
    [NoLegajo] int  NOT NULL,
    [Nombres] varchar(100)  NOT NULL,
    [Apellidos] varchar(70)  NOT NULL,
    [DNI] nchar(8)  NOT NULL,
    [CUIL] nchar(11)  NOT NULL,
    [FechaNacimiento] datetime  NULL,
    [Telefono] varchar(200)  NULL,
    [Celular] varchar(200)  NULL,
    [Domicilio] varchar(200)  NULL,
    [FechaIngreso] datetime  NULL,
    [Hijos] int  NULL,
    [idDepartamento] int  NULL,
    [IdObraSocial] int  NULL,
    [idSindicato] int  NULL,
    [idEspecialidad] int  NULL,
    [idCategoriaEmpleado] int  NULL,
    [NoCuentaFondoDesempleo] varchar(50)  NULL,
    [Ieric] bit  NULL,
    [FechaCeseLaboral] datetime  NULL,
    [Comentario] varchar(200)  NULL,
    [IdLocalidad] int  NULL,
    [EstadoCivil] int  NULL,
    [IdNacionalidad] int  NULL,
    [LibretaFondoDesempleo] bit  NULL,
    [IdSexo] int  NULL,
    [RegistroConducir] bit  NULL,
    [IDEmpresaAFectada] int  NULL,
    [IDZona] int  NULL,
    [IdUsuarioAlta] int  NULL,
    [IdUsuarioModificacion] int  NULL,
    [FechaAlta] datetime  NULL,
    [FechaUltimaModificacion] datetime  NULL
);
GO

-- Creating table 'Empresas'
CREATE TABLE [dbo].[Empresas] (
    [idEmpresa] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NULL,
    [Razon] varchar(50)  NULL,
    [CUIT] nchar(11)  NULL,
    [Direccion] varchar(50)  NULL,
    [idProvincia] int  NULL,
    [IdLocalidad] int  NULL,
    [CodigoPostal] nchar(5)  NULL
);
GO

-- Creating table 'EmpresasClientes'
CREATE TABLE [dbo].[EmpresasClientes] (
    [IDEmpresaCliente] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(150)  NULL
);
GO

-- Creating table 'Especialidades'
CREATE TABLE [dbo].[Especialidades] (
    [idEspecialidad] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NULL
);
GO

-- Creating table 'EstadoCivil'
CREATE TABLE [dbo].[EstadoCivil] (
    [IDEstadoCivil] int IDENTITY(1,1) NOT NULL,
    [EstadoCivil1] varchar(50)  NULL
);
GO

-- Creating table 'Estados'
CREATE TABLE [dbo].[Estados] (
    [idEstado] int  NOT NULL,
    [Estados1] varchar(50)  NULL
);
GO

-- Creating table 'EstudiosRealizados'
CREATE TABLE [dbo].[EstudiosRealizados] (
    [IDEstudios] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NULL
);
GO

-- Creating table 'IngresoMateriales'
CREATE TABLE [dbo].[IngresoMateriales] (
    [iDingresoMateriales] int  NOT NULL,
    [Fecha] datetime  NULL,
    [NoRemito] nchar(12)  NULL,
    [IdAlmacen] int  NULL,
    [IdRecepcion] int  NULL,
    [idArticulo] int  NULL,
    [Cantidad] float  NULL
);
GO

-- Creating table 'Localidades'
CREATE TABLE [dbo].[Localidades] (
    [IdLocalidad] int IDENTITY(1,1) NOT NULL,
    [Localidades1] varchar(50)  NULL,
    [CodigoPostal] nchar(5)  NULL
);
GO

-- Creating table 'Mantenimiento'
CREATE TABLE [dbo].[Mantenimiento] (
    [IDMantenimiento] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NULL,
    [IdVehiculo] int  NULL,
    [Km] int  NULL,
    [IDEmpleado] int  NULL,
    [IDTaller] int  NULL,
    [IDActividadMantenimiento] int  NULL,
    [Comentario] varchar(350)  NULL,
    [IDUserTransac] int  NULL
);
GO

-- Creating table 'MarcasVehiculos'
CREATE TABLE [dbo].[MarcasVehiculos] (
    [IDMarca] int IDENTITY(1,1) NOT NULL,
    [Marcas] varchar(150)  NULL
);
GO

-- Creating table 'MediosPago'
CREATE TABLE [dbo].[MediosPago] (
    [IdMedioPago] int  NOT NULL,
    [MediosPago1] varchar(50)  NULL
);
GO

-- Creating table 'Menus'
CREATE TABLE [dbo].[Menus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Menu] varchar(100)  NULL
);
GO

-- Creating table 'ModelosVehiculos'
CREATE TABLE [dbo].[ModelosVehiculos] (
    [IDModeloVehiculo] int IDENTITY(1,1) NOT NULL,
    [Modelo] varchar(150)  NULL,
    [MarcaID] int  NULL
);
GO

-- Creating table 'Nacionalidades'
CREATE TABLE [dbo].[Nacionalidades] (
    [IdNacionalidad] int IDENTITY(1,1) NOT NULL,
    [Nacionalidad] varchar(50)  NULL
);
GO

-- Creating table 'NetRoles'
CREATE TABLE [dbo].[NetRoles] (
    [Id] int  NOT NULL,
    [ConcurrencyStamp] nvarchar(max)  NULL,
    [Name] nvarchar(256)  NULL,
    [NormalizedName] nvarchar(256)  NULL
);
GO

-- Creating table 'NetUser'
CREATE TABLE [dbo].[NetUser] (
    [Id] int  NOT NULL,
    [AccessFailedCount] int  NOT NULL,
    [ConcurrencyStamp] nvarchar(max)  NULL,
    [Email] nvarchar(256)  NULL,
    [EmailConfirmed] bit  NOT NULL,
    [LockoutEnabled] bit  NOT NULL,
    [LockoutEnd] datetimeoffset  NULL,
    [NormalizedEmail] nvarchar(256)  NULL,
    [NormalizedUserName] nvarchar(256)  NULL,
    [PasswordHash] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [PhoneNumberConfirmed] bit  NOT NULL,
    [SecurityStamp] nvarchar(max)  NULL,
    [TwoFactorEnabled] bit  NOT NULL,
    [UserName] nvarchar(256)  NULL
);
GO

-- Creating table 'NetUserLogin'
CREATE TABLE [dbo].[NetUserLogin] (
    [UserId] nvarchar(450)  NOT NULL,
    [LoginProvider] nvarchar(450)  NOT NULL,
    [Name] nvarchar(450)  NOT NULL,
    [Value] nvarchar(max)  NULL
);
GO

-- Creating table 'ObraSocial'
CREATE TABLE [dbo].[ObraSocial] (
    [idObraSocial] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(100)  NULL
);
GO

-- Creating table 'Pagos'
CREATE TABLE [dbo].[Pagos] (
    [Idpago] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NULL,
    [Importe] float  NULL,
    [Concepto] varchar(400)  NULL,
    [RetencionID] int  NULL
);
GO

-- Creating table 'PermissionMenus'
CREATE TABLE [dbo].[PermissionMenus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rollid] nvarchar(450)  NULL,
    [MenuId] int  NULL,
    [IsEnable] bit  NULL
);
GO

-- Creating table 'Personas'
CREATE TABLE [dbo].[Personas] (
    [IdPersona] int IDENTITY(1,1) NOT NULL,
    [ImagenPerfil] varbinary(max)  NULL,
    [Nombre] varchar(50)  NULL,
    [Apellido] varchar(50)  NULL,
    [DNI] nchar(8)  NULL,
    [CUIL] nchar(11)  NULL,
    [FechaNacimiento] datetime  NULL,
    [Telefono] varchar(50)  NULL,
    [Celular] varchar(50)  NULL,
    [Domicilio] varchar(100)  NULL,
    [IdLocalidad] int  NULL,
    [idObraSocial] int  NULL,
    [Hijos] int  NULL,
    [EstadoCivil] int  NULL,
    [IdNacionalidad] int  NULL,
    [LibretaFondoDesempleo] bit  NULL,
    [IdSexo] int  NULL,
    [RegistroConducir] bit  NULL
);
GO

-- Creating table 'PolizasSeguro'
CREATE TABLE [dbo].[PolizasSeguro] (
    [IDPolizaSeguro] int IDENTITY(1,1) NOT NULL,
    [Nopoliza] nchar(20)  NULL,
    [Descripcion] varchar(200)  NULL,
    [FechaEmision] datetime  NULL,
    [FechaFin] datetime  NULL,
    [IDCompania] int  NULL
);
GO

-- Creating table 'ProductoresSeguro'
CREATE TABLE [dbo].[ProductoresSeguro] (
    [IdProductorSeguro] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NULL,
    [Direccion] varchar(50)  NULL,
    [email] varchar(50)  NULL,
    [telefono] varchar(50)  NULL
);
GO

-- Creating table 'Profiles'
CREATE TABLE [dbo].[Profiles] (
    [Id_Profiles] int  NOT NULL,
    [Profiles1] nchar(15)  NULL
);
GO

-- Creating table 'Proveedores'
CREATE TABLE [dbo].[Proveedores] (
    [IdProveedores] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(150)  NULL,
    [Razon] varchar(150)  NULL,
    [Cuit] nchar(11)  NOT NULL,
    [IngresosBrutos] nchar(20)  NULL,
    [Direccion] varchar(50)  NULL,
    [IDProvincia] int  NOT NULL,
    [IDLocalidad] int  NOT NULL,
    [Telefono] nchar(70)  NULL,
    [FechaIngreso] datetime  NULL,
    [IDRubro] int  NULL,
    [UserAltaID] int  NULL,
    [FechaAlta] datetime  NULL,
    [UserUltModificacion] int  NULL,
    [FechaUltimaModificacion] datetime  NULL
);
GO

-- Creating table 'Provincias'
CREATE TABLE [dbo].[Provincias] (
    [IDProvincias] int IDENTITY(1,1) NOT NULL,
    [Provincias1] varchar(50)  NULL
);
GO

-- Creating table 'Referencias'
CREATE TABLE [dbo].[Referencias] (
    [IDReferencia] int IDENTITY(1,1) NOT NULL,
    [Nombre] varchar(50)  NULL,
    [Telefono] varchar(50)  NULL,
    [IDPersona] int  NULL
);
GO

-- Creating table 'RegistroConducirBool'
CREATE TABLE [dbo].[RegistroConducirBool] (
    [IDRegistroConducir] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NULL
);
GO

-- Creating table 'RubroProveedor'
CREATE TABLE [dbo].[RubroProveedor] (
    [IDRubroProveedor] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(50)  NULL
);
GO

-- Creating table 'Sexos'
CREATE TABLE [dbo].[Sexos] (
    [IDSexo] int IDENTITY(1,1) NOT NULL,
    [Sexo] varchar(30)  NULL
);
GO

-- Creating table 'Sindicatos'
CREATE TABLE [dbo].[Sindicatos] (
    [idSindicato] int IDENTITY(1,1) NOT NULL,
    [Descripcion] varchar(100)  NULL
);
GO

-- Creating table 'SolicitudesEmpleo'
CREATE TABLE [dbo].[SolicitudesEmpleo] (
    [IdSolicitudEmpleo] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NULL,
    [idPersona] int  NULL,
    [AntecedentesLaborales] varchar(300)  NULL,
    [PretencionRemunerativa] float  NULL
);
GO

-- Creating table 'SubMenus'
CREATE TABLE [dbo].[SubMenus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Submenu] varchar(50)  NULL,
    [MenuID] int  NULL,
    [IsEnable] bit  NULL
);
GO

-- Creating table 'TablaDivisorCalculo'
CREATE TABLE [dbo].[TablaDivisorCalculo] (
    [IdDivisor] int IDENTITY(1,1) NOT NULL,
    [Divisor] varchar(50)  NULL,
    [CantidadConectores] int  NULL
);
GO

-- Creating table 'Talleres'
CREATE TABLE [dbo].[Talleres] (
    [IDTalleres] int IDENTITY(1,1) NOT NULL,
    [NombreTaller] varchar(150)  NULL,
    [Direccion] varchar(150)  NULL,
    [IDLocalidad] int  NULL,
    [TelefonoCotacto] varchar(150)  NULL,
    [NombreEncargado] varchar(150)  NULL,
    [IdTipoTaller] int  NULL
);
GO

-- Creating table 'TiposComprobante'
CREATE TABLE [dbo].[TiposComprobante] (
    [IdTipoComprobante] int IDENTITY(1,1) NOT NULL,
    [TipoComprobante] varchar(50)  NULL
);
GO

-- Creating table 'TiposFactura'
CREATE TABLE [dbo].[TiposFactura] (
    [IdTipoFactura] int IDENTITY(1,1) NOT NULL,
    [TipoFactura] varchar(50)  NULL
);
GO

-- Creating table 'TipoTaller'
CREATE TABLE [dbo].[TipoTaller] (
    [IdTipoTaller] int IDENTITY(1,1) NOT NULL,
    [DescripcionTaller] varchar(150)  NULL
);
GO

-- Creating table 'Ubicacion'
CREATE TABLE [dbo].[Ubicacion] (
    [IdUbicacion] int  NOT NULL,
    [Ubicacion1] varchar(50)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [IDUser] nchar(15)  NOT NULL,
    [Username] nchar(15)  NULL,
    [Password] nchar(15)  NULL,
    [IDProfile] int  NULL,
    [PasswordHash] binary(64)  NULL
);
GO

-- Creating table 'Vehiculos'
CREATE TABLE [dbo].[Vehiculos] (
    [IDVehiculo] int IDENTITY(1,1) NOT NULL,
    [Activo] bit  NULL,
    [Patente] nchar(10)  NULL,
    [Marca] int  NULL,
    [Modelo] int  NULL,
    [Nochasis] varchar(150)  NULL,
    [NoCarroceria] varchar(50)  NULL,
    [NoMotor] varchar(50)  NULL,
    [IdPolizaSeguro] int  NULL,
    [NeumaticoRepuesto] bit  NULL,
    [IDCombustible] int  NULL,
    [Year] int  NULL,
    [FechaCompra] datetime  NULL,
    [FechaTransferencia] datetime  NULL,
    [VigenciaVTV] datetime  NULL,
    [IdChofer] int  NULL,
    [Titular] varchar(150)  NULL,
    [KM] int  NULL,
    [TenantID] int  NULL,
    [UserTransac] int  NULL
);
GO

-- Creating table 'Vencimientos'
CREATE TABLE [dbo].[Vencimientos] (
    [IdVencimiento] int  NOT NULL,
    [Vencimiento] nchar(15)  NULL
);
GO

-- Creating table 'Zonas'
CREATE TABLE [dbo].[Zonas] (
    [IdZona] int  NOT NULL,
    [Zonas1] varchar(50)  NULL
);
GO

-- Creating table 'Choferes'
CREATE TABLE [dbo].[Choferes] (
    [IDEmpleado] int IDENTITY(1,1) NOT NULL,
    [Chofer] varchar(171)  NOT NULL
);
GO

-- Creating table 'CuentasCorrientes'
CREATE TABLE [dbo].[CuentasCorrientes] (
    [Nombre] varchar(150)  NULL,
    [Razon] varchar(150)  NULL,
    [Cuit] nchar(11)  NOT NULL,
    [NumeroCuenta] nchar(11)  NULL,
    [Vencimiento] int  NULL,
    [Comentario] varchar(50)  NULL
);
GO

-- Creating table 'DatosEmpleadosActivos'
CREATE TABLE [dbo].[DatosEmpleadosActivos] (
    [IDEmpleado] int  NOT NULL,
    [NoLegajo] varchar(12)  NOT NULL,
    [ImagenPerfil] varbinary(max)  NULL,
    [Nombre] varchar(50)  NULL,
    [Apellido] varchar(50)  NULL,
    [DNI] nchar(8)  NULL,
    [CUIL] nchar(11)  NULL,
    [FechaNacimiento] datetime  NULL,
    [Sexo] varchar(30)  NULL,
    [EstadoCivil] varchar(50)  NULL,
    [Nacionalidad] varchar(50)  NULL,
    [Domicilio] varchar(100)  NULL,
    [Localidades] varchar(50)  NULL,
    [CodigoPostal] nchar(5)  NULL,
    [Descripcion] varchar(50)  NOT NULL,
    [CategoriaEmpleado1] varchar(50)  NULL,
    [Activo] bit  NULL
);
GO

-- Creating table 'DetallePago'
CREATE TABLE [dbo].[DetallePago] (
    [Sucursal] varchar(4)  NULL,
    [NoFactura] varchar(8)  NULL,
    [Fecha] datetime  NULL,
    [Idpago] int  NOT NULL,
    [Expr1] datetime  NULL,
    [Importe] float  NULL,
    [Concepto] varchar(400)  NULL,
    [MediosPago] varchar(50)  NULL,
    [NoCheque] varchar(50)  NULL,
    [FechaVencimientoCheque] datetime  NULL,
    [Expr2] float  NULL
);
GO

-- Creating table 'DetallesSolicitudesEmpleo'
CREATE TABLE [dbo].[DetallesSolicitudesEmpleo] (
    [Fecha] datetime  NULL,
    [IdPersona] int  NOT NULL,
    [Nombre] varchar(50)  NULL,
    [Apellido] varchar(50)  NULL,
    [Sexo] varchar(30)  NULL,
    [DNI] nchar(8)  NULL,
    [CUIL] nchar(11)  NULL,
    [FechaNacimiento] datetime  NULL,
    [Nacionalidad] varchar(50)  NULL,
    [Domicilio] varchar(100)  NULL,
    [localidad] varchar(50)  NULL,
    [CodigoPostal] nchar(5)  NULL,
    [Telefono] varchar(50)  NULL,
    [Celular] varchar(50)  NULL,
    [EstadoCivil] varchar(50)  NULL,
    [Hijos] int  NULL,
    [RegistroConducir] bit  NULL,
    [Obrasocial] varchar(100)  NULL,
    [LibretaFondoDesempleo] bit  NULL,
    [AntecedentesLaborales] varchar(300)  NULL,
    [PretencionRemunerativa] float  NULL
);
GO

-- Creating table 'ListaTalleresMecanicos'
CREATE TABLE [dbo].[ListaTalleresMecanicos] (
    [IDTalleres] int  NOT NULL,
    [NombreTaller] varchar(150)  NULL,
    [Direccion] varchar(150)  NULL,
    [Localidades] varchar(50)  NULL,
    [DescripcionTaller] varchar(150)  NULL,
    [NombreEncargado] varchar(150)  NULL,
    [TelefonoCotacto] varchar(150)  NULL
);
GO

-- Creating table 'NominaCV'
CREATE TABLE [dbo].[NominaCV] (
    [IDEmpleado] int IDENTITY(1,1) NOT NULL,
    [Nombres] varchar(100)  NOT NULL,
    [Apellidos] varchar(70)  NOT NULL,
    [DNI] nchar(8)  NOT NULL
);
GO

-- Creating table 'NominaTelecentro'
CREATE TABLE [dbo].[NominaTelecentro] (
    [IDEmpleado] int IDENTITY(1,1) NOT NULL,
    [Nombres] varchar(100)  NOT NULL,
    [Apellidos] varchar(70)  NOT NULL,
    [DNI] nchar(8)  NOT NULL
);
GO

-- Creating table 'Solicitudesempleos'
CREATE TABLE [dbo].[Solicitudesempleos] (
    [IdPersona] int IDENTITY(1,1) NOT NULL,
    [nombrepersona] varchar(100)  NULL
);
GO

-- Creating table 'View_DetalleArticulo'
CREATE TABLE [dbo].[View_DetalleArticulo] (
    [IDArticulo] int  NOT NULL,
    [Nombre] varchar(100)  NULL,
    [Descripcion] varchar(100)  NULL,
    [Codigo] varchar(50)  NULL,
    [Iva] float  NULL,
    [Categoria] varchar(50)  NULL,
    [Ubicacion] varchar(50)  NULL
);
GO

-- Creating table 'View_DetalleArticuloComprobante'
CREATE TABLE [dbo].[View_DetalleArticuloComprobante] (
    [Nombre] varchar(100)  NULL,
    [Cantidad] float  NULL,
    [Precio] float  NULL,
    [Importe] float  NULL,
    [Fecha] datetime  NULL,
    [IdComprobante] int  NOT NULL,
    [idTable_DetallesComprobanteArticulos] int  NOT NULL,
    [Iva] float  NULL
);
GO

-- Creating table 'View_ListaEmpleados'
CREATE TABLE [dbo].[View_ListaEmpleados] (
    [IDEmpleado] int IDENTITY(1,1) NOT NULL,
    [Nombres] varchar(151)  NULL
);
GO

-- Creating table 'View_Proveedores'
CREATE TABLE [dbo].[View_Proveedores] (
    [Nombre] varchar(50)  NULL,
    [Razon] varchar(150)  NULL,
    [Cuit] nchar(11)  NOT NULL,
    [IngresosBrutos] nchar(20)  NULL,
    [Direccion] varchar(50)  NULL,
    [Telefono] nchar(25)  NULL,
    [FechaIngreso] datetime  NULL,
    [Localidades] varchar(50)  NULL,
    [Provincias] varchar(50)  NULL,
    [RubroProveedor] varchar(50)  NULL
);
GO

-- Creating table 'PadronRgsRet'
CREATE TABLE [dbo].[PadronRgsRet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Regimen] nchar(2)  NOT NULL,
    [FechaPublicacion] datetime  NOT NULL,
    [FechaDesde] datetime  NOT NULL,
    [FechaHasta] datetime  NOT NULL,
    [Cuit] nchar(11)  NOT NULL,
    [TipoContribuyenteInsc] nchar(2)  NOT NULL,
    [MarcaAltaBaja] nchar(2)  NOT NULL,
    [MarcaCambioAlicuota] nchar(2)  NOT NULL,
    [Alicuota] float  NOT NULL,
    [Grupo] int  NOT NULL
);
GO

-- Creating table 'Retenciones'
CREATE TABLE [dbo].[Retenciones] (
    [IDRetencion] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NULL,
    [Alicuota] float  NULL,
    [Importe] float  NULL,
    [EmpresaID] int  NULL
);
GO

-- Creating table 'NetUsersRoles'
CREATE TABLE [dbo].[NetUsersRoles] (
    [NetRoles_Id] int  NOT NULL,
    [NetUser_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IDActividadMantenimiento] in table 'ActividadMantenimiento'
ALTER TABLE [dbo].[ActividadMantenimiento]
ADD CONSTRAINT [PK_ActividadMantenimiento]
    PRIMARY KEY CLUSTERED ([IDActividadMantenimiento] ASC);
GO

-- Creating primary key on [IDAfectadoEmpresaCliente] in table 'AfectadoEmpresaCliente'
ALTER TABLE [dbo].[AfectadoEmpresaCliente]
ADD CONSTRAINT [PK_AfectadoEmpresaCliente]
    PRIMARY KEY CLUSTERED ([IDAfectadoEmpresaCliente] ASC);
GO

-- Creating primary key on [IdAlmacen] in table 'Almacenes'
ALTER TABLE [dbo].[Almacenes]
ADD CONSTRAINT [PK_Almacenes]
    PRIMARY KEY CLUSTERED ([IdAlmacen] ASC);
GO

-- Creating primary key on [IDArticulo] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [PK_Articulos]
    PRIMARY KEY CLUSTERED ([IDArticulo] ASC);
GO

-- Creating primary key on [IdBanco] in table 'Bancos'
ALTER TABLE [dbo].[Bancos]
ADD CONSTRAINT [PK_Bancos]
    PRIMARY KEY CLUSTERED ([IdBanco] ASC);
GO

-- Creating primary key on [idCategoriaEmpleado] in table 'CategoriaEmpleado'
ALTER TABLE [dbo].[CategoriaEmpleado]
ADD CONSTRAINT [PK_CategoriaEmpleado]
    PRIMARY KEY CLUSTERED ([idCategoriaEmpleado] ASC);
GO

-- Creating primary key on [IDCategoria] in table 'Categorias'
ALTER TABLE [dbo].[Categorias]
ADD CONSTRAINT [PK_Categorias]
    PRIMARY KEY CLUSTERED ([IDCategoria] ASC);
GO

-- Creating primary key on [IdCentroCosto] in table 'CentroCostos'
ALTER TABLE [dbo].[CentroCostos]
ADD CONSTRAINT [PK_CentroCostos]
    PRIMARY KEY CLUSTERED ([IdCentroCosto] ASC);
GO

-- Creating primary key on [IDCombustible] in table 'Combustibles'
ALTER TABLE [dbo].[Combustibles]
ADD CONSTRAINT [PK_Combustibles]
    PRIMARY KEY CLUSTERED ([IDCombustible] ASC);
GO

-- Creating primary key on [IdComprobante] in table 'Comprobantes'
ALTER TABLE [dbo].[Comprobantes]
ADD CONSTRAINT [PK_Comprobantes]
    PRIMARY KEY CLUSTERED ([IdComprobante] ASC);
GO

-- Creating primary key on [IdCondicionCompra] in table 'CondicionesCompra'
ALTER TABLE [dbo].[CondicionesCompra]
ADD CONSTRAINT [PK_CondicionesCompra]
    PRIMARY KEY CLUSTERED ([IdCondicionCompra] ASC);
GO

-- Creating primary key on [IdContable] in table 'Contable'
ALTER TABLE [dbo].[Contable]
ADD CONSTRAINT [PK_Contable]
    PRIMARY KEY CLUSTERED ([IdContable] ASC);
GO

-- Creating primary key on [IdCuentaCorriente] in table 'CuentaCorriente'
ALTER TABLE [dbo].[CuentaCorriente]
ADD CONSTRAINT [PK_CuentaCorriente]
    PRIMARY KEY CLUSTERED ([IdCuentaCorriente] ASC);
GO

-- Creating primary key on [IdDepartamento] in table 'Departamentos'
ALTER TABLE [dbo].[Departamentos]
ADD CONSTRAINT [PK_Departamentos]
    PRIMARY KEY CLUSTERED ([IdDepartamento] ASC);
GO

-- Creating primary key on [IdDetalleMantenimientoRepuesto] in table 'DetalleMantenimientoRepuestos'
ALTER TABLE [dbo].[DetalleMantenimientoRepuestos]
ADD CONSTRAINT [PK_DetalleMantenimientoRepuestos]
    PRIMARY KEY CLUSTERED ([IdDetalleMantenimientoRepuesto] ASC);
GO

-- Creating primary key on [IdDetalleMedioPago] in table 'DetalleMediosPagos'
ALTER TABLE [dbo].[DetalleMediosPagos]
ADD CONSTRAINT [PK_DetalleMediosPagos]
    PRIMARY KEY CLUSTERED ([IdDetalleMedioPago] ASC);
GO

-- Creating primary key on [IdDetalleProveedor_ProductorSeguro] in table 'DetalleProveedor_ProductorSeguro'
ALTER TABLE [dbo].[DetalleProveedor_ProductorSeguro]
ADD CONSTRAINT [PK_DetalleProveedor_ProductorSeguro]
    PRIMARY KEY CLUSTERED ([IdDetalleProveedor_ProductorSeguro] ASC);
GO

-- Creating primary key on [idTable_DetallesComprobanteArticulos] in table 'DetallesComprobanteArticulos'
ALTER TABLE [dbo].[DetallesComprobanteArticulos]
ADD CONSTRAINT [PK_DetallesComprobanteArticulos]
    PRIMARY KEY CLUSTERED ([idTable_DetallesComprobanteArticulos] ASC);
GO

-- Creating primary key on [IdDetallePago] in table 'DetallesPago'
ALTER TABLE [dbo].[DetallesPago]
ADD CONSTRAINT [PK_DetallesPago]
    PRIMARY KEY CLUSTERED ([IdDetallePago] ASC);
GO

-- Creating primary key on [IDEmpleado] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [PK_Empleados]
    PRIMARY KEY CLUSTERED ([IDEmpleado] ASC);
GO

-- Creating primary key on [idEmpresa] in table 'Empresas'
ALTER TABLE [dbo].[Empresas]
ADD CONSTRAINT [PK_Empresas]
    PRIMARY KEY CLUSTERED ([idEmpresa] ASC);
GO

-- Creating primary key on [IDEmpresaCliente] in table 'EmpresasClientes'
ALTER TABLE [dbo].[EmpresasClientes]
ADD CONSTRAINT [PK_EmpresasClientes]
    PRIMARY KEY CLUSTERED ([IDEmpresaCliente] ASC);
GO

-- Creating primary key on [idEspecialidad] in table 'Especialidades'
ALTER TABLE [dbo].[Especialidades]
ADD CONSTRAINT [PK_Especialidades]
    PRIMARY KEY CLUSTERED ([idEspecialidad] ASC);
GO

-- Creating primary key on [IDEstadoCivil] in table 'EstadoCivil'
ALTER TABLE [dbo].[EstadoCivil]
ADD CONSTRAINT [PK_EstadoCivil]
    PRIMARY KEY CLUSTERED ([IDEstadoCivil] ASC);
GO

-- Creating primary key on [idEstado] in table 'Estados'
ALTER TABLE [dbo].[Estados]
ADD CONSTRAINT [PK_Estados]
    PRIMARY KEY CLUSTERED ([idEstado] ASC);
GO

-- Creating primary key on [IDEstudios] in table 'EstudiosRealizados'
ALTER TABLE [dbo].[EstudiosRealizados]
ADD CONSTRAINT [PK_EstudiosRealizados]
    PRIMARY KEY CLUSTERED ([IDEstudios] ASC);
GO

-- Creating primary key on [iDingresoMateriales] in table 'IngresoMateriales'
ALTER TABLE [dbo].[IngresoMateriales]
ADD CONSTRAINT [PK_IngresoMateriales]
    PRIMARY KEY CLUSTERED ([iDingresoMateriales] ASC);
GO

-- Creating primary key on [IdLocalidad] in table 'Localidades'
ALTER TABLE [dbo].[Localidades]
ADD CONSTRAINT [PK_Localidades]
    PRIMARY KEY CLUSTERED ([IdLocalidad] ASC);
GO

-- Creating primary key on [IDMantenimiento] in table 'Mantenimiento'
ALTER TABLE [dbo].[Mantenimiento]
ADD CONSTRAINT [PK_Mantenimiento]
    PRIMARY KEY CLUSTERED ([IDMantenimiento] ASC);
GO

-- Creating primary key on [IDMarca] in table 'MarcasVehiculos'
ALTER TABLE [dbo].[MarcasVehiculos]
ADD CONSTRAINT [PK_MarcasVehiculos]
    PRIMARY KEY CLUSTERED ([IDMarca] ASC);
GO

-- Creating primary key on [IdMedioPago] in table 'MediosPago'
ALTER TABLE [dbo].[MediosPago]
ADD CONSTRAINT [PK_MediosPago]
    PRIMARY KEY CLUSTERED ([IdMedioPago] ASC);
GO

-- Creating primary key on [Id] in table 'Menus'
ALTER TABLE [dbo].[Menus]
ADD CONSTRAINT [PK_Menus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [IDModeloVehiculo] in table 'ModelosVehiculos'
ALTER TABLE [dbo].[ModelosVehiculos]
ADD CONSTRAINT [PK_ModelosVehiculos]
    PRIMARY KEY CLUSTERED ([IDModeloVehiculo] ASC);
GO

-- Creating primary key on [IdNacionalidad] in table 'Nacionalidades'
ALTER TABLE [dbo].[Nacionalidades]
ADD CONSTRAINT [PK_Nacionalidades]
    PRIMARY KEY CLUSTERED ([IdNacionalidad] ASC);
GO

-- Creating primary key on [Id] in table 'NetRoles'
ALTER TABLE [dbo].[NetRoles]
ADD CONSTRAINT [PK_NetRoles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NetUser'
ALTER TABLE [dbo].[NetUser]
ADD CONSTRAINT [PK_NetUser]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [UserId], [LoginProvider], [Name] in table 'NetUserLogin'
ALTER TABLE [dbo].[NetUserLogin]
ADD CONSTRAINT [PK_NetUserLogin]
    PRIMARY KEY CLUSTERED ([UserId], [LoginProvider], [Name] ASC);
GO

-- Creating primary key on [idObraSocial] in table 'ObraSocial'
ALTER TABLE [dbo].[ObraSocial]
ADD CONSTRAINT [PK_ObraSocial]
    PRIMARY KEY CLUSTERED ([idObraSocial] ASC);
GO

-- Creating primary key on [Idpago] in table 'Pagos'
ALTER TABLE [dbo].[Pagos]
ADD CONSTRAINT [PK_Pagos]
    PRIMARY KEY CLUSTERED ([Idpago] ASC);
GO

-- Creating primary key on [Id] in table 'PermissionMenus'
ALTER TABLE [dbo].[PermissionMenus]
ADD CONSTRAINT [PK_PermissionMenus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [IdPersona] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [PK_Personas]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- Creating primary key on [IDPolizaSeguro] in table 'PolizasSeguro'
ALTER TABLE [dbo].[PolizasSeguro]
ADD CONSTRAINT [PK_PolizasSeguro]
    PRIMARY KEY CLUSTERED ([IDPolizaSeguro] ASC);
GO

-- Creating primary key on [IdProductorSeguro] in table 'ProductoresSeguro'
ALTER TABLE [dbo].[ProductoresSeguro]
ADD CONSTRAINT [PK_ProductoresSeguro]
    PRIMARY KEY CLUSTERED ([IdProductorSeguro] ASC);
GO

-- Creating primary key on [Id_Profiles] in table 'Profiles'
ALTER TABLE [dbo].[Profiles]
ADD CONSTRAINT [PK_Profiles]
    PRIMARY KEY CLUSTERED ([Id_Profiles] ASC);
GO

-- Creating primary key on [IdProveedores] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [PK_Proveedores]
    PRIMARY KEY CLUSTERED ([IdProveedores] ASC);
GO

-- Creating primary key on [IDProvincias] in table 'Provincias'
ALTER TABLE [dbo].[Provincias]
ADD CONSTRAINT [PK_Provincias]
    PRIMARY KEY CLUSTERED ([IDProvincias] ASC);
GO

-- Creating primary key on [IDReferencia] in table 'Referencias'
ALTER TABLE [dbo].[Referencias]
ADD CONSTRAINT [PK_Referencias]
    PRIMARY KEY CLUSTERED ([IDReferencia] ASC);
GO

-- Creating primary key on [IDRegistroConducir] in table 'RegistroConducirBool'
ALTER TABLE [dbo].[RegistroConducirBool]
ADD CONSTRAINT [PK_RegistroConducirBool]
    PRIMARY KEY CLUSTERED ([IDRegistroConducir] ASC);
GO

-- Creating primary key on [IDRubroProveedor] in table 'RubroProveedor'
ALTER TABLE [dbo].[RubroProveedor]
ADD CONSTRAINT [PK_RubroProveedor]
    PRIMARY KEY CLUSTERED ([IDRubroProveedor] ASC);
GO

-- Creating primary key on [IDSexo] in table 'Sexos'
ALTER TABLE [dbo].[Sexos]
ADD CONSTRAINT [PK_Sexos]
    PRIMARY KEY CLUSTERED ([IDSexo] ASC);
GO

-- Creating primary key on [idSindicato] in table 'Sindicatos'
ALTER TABLE [dbo].[Sindicatos]
ADD CONSTRAINT [PK_Sindicatos]
    PRIMARY KEY CLUSTERED ([idSindicato] ASC);
GO

-- Creating primary key on [IdSolicitudEmpleo] in table 'SolicitudesEmpleo'
ALTER TABLE [dbo].[SolicitudesEmpleo]
ADD CONSTRAINT [PK_SolicitudesEmpleo]
    PRIMARY KEY CLUSTERED ([IdSolicitudEmpleo] ASC);
GO

-- Creating primary key on [Id] in table 'SubMenus'
ALTER TABLE [dbo].[SubMenus]
ADD CONSTRAINT [PK_SubMenus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [IdDivisor] in table 'TablaDivisorCalculo'
ALTER TABLE [dbo].[TablaDivisorCalculo]
ADD CONSTRAINT [PK_TablaDivisorCalculo]
    PRIMARY KEY CLUSTERED ([IdDivisor] ASC);
GO

-- Creating primary key on [IDTalleres] in table 'Talleres'
ALTER TABLE [dbo].[Talleres]
ADD CONSTRAINT [PK_Talleres]
    PRIMARY KEY CLUSTERED ([IDTalleres] ASC);
GO

-- Creating primary key on [IdTipoComprobante] in table 'TiposComprobante'
ALTER TABLE [dbo].[TiposComprobante]
ADD CONSTRAINT [PK_TiposComprobante]
    PRIMARY KEY CLUSTERED ([IdTipoComprobante] ASC);
GO

-- Creating primary key on [IdTipoFactura] in table 'TiposFactura'
ALTER TABLE [dbo].[TiposFactura]
ADD CONSTRAINT [PK_TiposFactura]
    PRIMARY KEY CLUSTERED ([IdTipoFactura] ASC);
GO

-- Creating primary key on [IdTipoTaller] in table 'TipoTaller'
ALTER TABLE [dbo].[TipoTaller]
ADD CONSTRAINT [PK_TipoTaller]
    PRIMARY KEY CLUSTERED ([IdTipoTaller] ASC);
GO

-- Creating primary key on [IdUbicacion] in table 'Ubicacion'
ALTER TABLE [dbo].[Ubicacion]
ADD CONSTRAINT [PK_Ubicacion]
    PRIMARY KEY CLUSTERED ([IdUbicacion] ASC);
GO

-- Creating primary key on [IDUser] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([IDUser] ASC);
GO

-- Creating primary key on [IDVehiculo] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [PK_Vehiculos]
    PRIMARY KEY CLUSTERED ([IDVehiculo] ASC);
GO

-- Creating primary key on [IdVencimiento] in table 'Vencimientos'
ALTER TABLE [dbo].[Vencimientos]
ADD CONSTRAINT [PK_Vencimientos]
    PRIMARY KEY CLUSTERED ([IdVencimiento] ASC);
GO

-- Creating primary key on [IdZona] in table 'Zonas'
ALTER TABLE [dbo].[Zonas]
ADD CONSTRAINT [PK_Zonas]
    PRIMARY KEY CLUSTERED ([IdZona] ASC);
GO

-- Creating primary key on [IDEmpleado], [Chofer] in table 'Choferes'
ALTER TABLE [dbo].[Choferes]
ADD CONSTRAINT [PK_Choferes]
    PRIMARY KEY CLUSTERED ([IDEmpleado], [Chofer] ASC);
GO

-- Creating primary key on [Cuit] in table 'CuentasCorrientes'
ALTER TABLE [dbo].[CuentasCorrientes]
ADD CONSTRAINT [PK_CuentasCorrientes]
    PRIMARY KEY CLUSTERED ([Cuit] ASC);
GO

-- Creating primary key on [IDEmpleado], [NoLegajo], [Descripcion] in table 'DatosEmpleadosActivos'
ALTER TABLE [dbo].[DatosEmpleadosActivos]
ADD CONSTRAINT [PK_DatosEmpleadosActivos]
    PRIMARY KEY CLUSTERED ([IDEmpleado], [NoLegajo], [Descripcion] ASC);
GO

-- Creating primary key on [Idpago] in table 'DetallePago'
ALTER TABLE [dbo].[DetallePago]
ADD CONSTRAINT [PK_DetallePago]
    PRIMARY KEY CLUSTERED ([Idpago] ASC);
GO

-- Creating primary key on [IdPersona] in table 'DetallesSolicitudesEmpleo'
ALTER TABLE [dbo].[DetallesSolicitudesEmpleo]
ADD CONSTRAINT [PK_DetallesSolicitudesEmpleo]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- Creating primary key on [IDTalleres] in table 'ListaTalleresMecanicos'
ALTER TABLE [dbo].[ListaTalleresMecanicos]
ADD CONSTRAINT [PK_ListaTalleresMecanicos]
    PRIMARY KEY CLUSTERED ([IDTalleres] ASC);
GO

-- Creating primary key on [IDEmpleado], [Nombres], [Apellidos], [DNI] in table 'NominaCV'
ALTER TABLE [dbo].[NominaCV]
ADD CONSTRAINT [PK_NominaCV]
    PRIMARY KEY CLUSTERED ([IDEmpleado], [Nombres], [Apellidos], [DNI] ASC);
GO

-- Creating primary key on [IDEmpleado], [Nombres], [Apellidos], [DNI] in table 'NominaTelecentro'
ALTER TABLE [dbo].[NominaTelecentro]
ADD CONSTRAINT [PK_NominaTelecentro]
    PRIMARY KEY CLUSTERED ([IDEmpleado], [Nombres], [Apellidos], [DNI] ASC);
GO

-- Creating primary key on [IdPersona] in table 'Solicitudesempleos'
ALTER TABLE [dbo].[Solicitudesempleos]
ADD CONSTRAINT [PK_Solicitudesempleos]
    PRIMARY KEY CLUSTERED ([IdPersona] ASC);
GO

-- Creating primary key on [IDArticulo] in table 'View_DetalleArticulo'
ALTER TABLE [dbo].[View_DetalleArticulo]
ADD CONSTRAINT [PK_View_DetalleArticulo]
    PRIMARY KEY CLUSTERED ([IDArticulo] ASC);
GO

-- Creating primary key on [IdComprobante], [idTable_DetallesComprobanteArticulos] in table 'View_DetalleArticuloComprobante'
ALTER TABLE [dbo].[View_DetalleArticuloComprobante]
ADD CONSTRAINT [PK_View_DetalleArticuloComprobante]
    PRIMARY KEY CLUSTERED ([IdComprobante], [idTable_DetallesComprobanteArticulos] ASC);
GO

-- Creating primary key on [IDEmpleado] in table 'View_ListaEmpleados'
ALTER TABLE [dbo].[View_ListaEmpleados]
ADD CONSTRAINT [PK_View_ListaEmpleados]
    PRIMARY KEY CLUSTERED ([IDEmpleado] ASC);
GO

-- Creating primary key on [Cuit] in table 'View_Proveedores'
ALTER TABLE [dbo].[View_Proveedores]
ADD CONSTRAINT [PK_View_Proveedores]
    PRIMARY KEY CLUSTERED ([Cuit] ASC);
GO

-- Creating primary key on [ID] in table 'PadronRgsRet'
ALTER TABLE [dbo].[PadronRgsRet]
ADD CONSTRAINT [PK_PadronRgsRet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [IDRetencion] in table 'Retenciones'
ALTER TABLE [dbo].[Retenciones]
ADD CONSTRAINT [PK_Retenciones]
    PRIMARY KEY CLUSTERED ([IDRetencion] ASC);
GO

-- Creating primary key on [NetRoles_Id], [NetUser_Id] in table 'NetUsersRoles'
ALTER TABLE [dbo].[NetUsersRoles]
ADD CONSTRAINT [PK_NetUsersRoles]
    PRIMARY KEY CLUSTERED ([NetRoles_Id], [NetUser_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IDActividadMantenimiento] in table 'Mantenimiento'
ALTER TABLE [dbo].[Mantenimiento]
ADD CONSTRAINT [FK_Mantenimiento_ActividadMantenimiento]
    FOREIGN KEY ([IDActividadMantenimiento])
    REFERENCES [dbo].[ActividadMantenimiento]
        ([IDActividadMantenimiento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Mantenimiento_ActividadMantenimiento'
CREATE INDEX [IX_FK_Mantenimiento_ActividadMantenimiento]
ON [dbo].[Mantenimiento]
    ([IDActividadMantenimiento]);
GO

-- Creating foreign key on [IdEmpleado] in table 'AfectadoEmpresaCliente'
ALTER TABLE [dbo].[AfectadoEmpresaCliente]
ADD CONSTRAINT [FK_AfectadoEmpresaCliente_Empleados]
    FOREIGN KEY ([IdEmpleado])
    REFERENCES [dbo].[Empleados]
        ([IDEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AfectadoEmpresaCliente_Empleados'
CREATE INDEX [IX_FK_AfectadoEmpresaCliente_Empleados]
ON [dbo].[AfectadoEmpresaCliente]
    ([IdEmpleado]);
GO

-- Creating foreign key on [IdEmpresaCliente] in table 'AfectadoEmpresaCliente'
ALTER TABLE [dbo].[AfectadoEmpresaCliente]
ADD CONSTRAINT [FK_AfectadoEmpresaCliente_EmpresasClientes]
    FOREIGN KEY ([IdEmpresaCliente])
    REFERENCES [dbo].[EmpresasClientes]
        ([IDEmpresaCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AfectadoEmpresaCliente_EmpresasClientes'
CREATE INDEX [IX_FK_AfectadoEmpresaCliente_EmpresasClientes]
ON [dbo].[AfectadoEmpresaCliente]
    ([IdEmpresaCliente]);
GO

-- Creating foreign key on [IDZona] in table 'Almacenes'
ALTER TABLE [dbo].[Almacenes]
ADD CONSTRAINT [FK_Table_Almacen_Table_Zonas]
    FOREIGN KEY ([IDZona])
    REFERENCES [dbo].[Zonas]
        ([IdZona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Almacen_Table_Zonas'
CREATE INDEX [IX_FK_Table_Almacen_Table_Zonas]
ON [dbo].[Almacenes]
    ([IDZona]);
GO

-- Creating foreign key on [IdAlmacen] in table 'IngresoMateriales'
ALTER TABLE [dbo].[IngresoMateriales]
ADD CONSTRAINT [FK_Table_IngresoMateriales_Table_Almacen]
    FOREIGN KEY ([IdAlmacen])
    REFERENCES [dbo].[Almacenes]
        ([IdAlmacen])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_IngresoMateriales_Table_Almacen'
CREATE INDEX [IX_FK_Table_IngresoMateriales_Table_Almacen]
ON [dbo].[IngresoMateriales]
    ([IdAlmacen]);
GO

-- Creating foreign key on [IDCategoria] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [FK_Table_Articulos_Table_Categoria]
    FOREIGN KEY ([IDCategoria])
    REFERENCES [dbo].[Categorias]
        ([IDCategoria])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Articulos_Table_Categoria'
CREATE INDEX [IX_FK_Table_Articulos_Table_Categoria]
ON [dbo].[Articulos]
    ([IDCategoria]);
GO

-- Creating foreign key on [IdUbicacion] in table 'Articulos'
ALTER TABLE [dbo].[Articulos]
ADD CONSTRAINT [FK_Table_Articulos_Table_Ubicacion]
    FOREIGN KEY ([IdUbicacion])
    REFERENCES [dbo].[Ubicacion]
        ([IdUbicacion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Articulos_Table_Ubicacion'
CREATE INDEX [IX_FK_Table_Articulos_Table_Ubicacion]
ON [dbo].[Articulos]
    ([IdUbicacion]);
GO

-- Creating foreign key on [IdArticulo] in table 'DetallesComprobanteArticulos'
ALTER TABLE [dbo].[DetallesComprobanteArticulos]
ADD CONSTRAINT [FK_Table_DetallesComprobanteArticulos_Table_Articulos]
    FOREIGN KEY ([IdArticulo])
    REFERENCES [dbo].[Articulos]
        ([IDArticulo])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_DetallesComprobanteArticulos_Table_Articulos'
CREATE INDEX [IX_FK_Table_DetallesComprobanteArticulos_Table_Articulos]
ON [dbo].[DetallesComprobanteArticulos]
    ([IdArticulo]);
GO

-- Creating foreign key on [idArticulo] in table 'IngresoMateriales'
ALTER TABLE [dbo].[IngresoMateriales]
ADD CONSTRAINT [FK_Table_IngresoMateriales_Table_Articulos]
    FOREIGN KEY ([idArticulo])
    REFERENCES [dbo].[Articulos]
        ([IDArticulo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_IngresoMateriales_Table_Articulos'
CREATE INDEX [IX_FK_Table_IngresoMateriales_Table_Articulos]
ON [dbo].[IngresoMateriales]
    ([idArticulo]);
GO

-- Creating foreign key on [IdBanco] in table 'DetalleMediosPagos'
ALTER TABLE [dbo].[DetalleMediosPagos]
ADD CONSTRAINT [FK_Table_DetalleMediosPago_Table_Banco]
    FOREIGN KEY ([IdBanco])
    REFERENCES [dbo].[Bancos]
        ([IdBanco])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_DetalleMediosPago_Table_Banco'
CREATE INDEX [IX_FK_Table_DetalleMediosPago_Table_Banco]
ON [dbo].[DetalleMediosPagos]
    ([IdBanco]);
GO

-- Creating foreign key on [IDSindicato] in table 'CategoriaEmpleado'
ALTER TABLE [dbo].[CategoriaEmpleado]
ADD CONSTRAINT [FK_CategoriaEmpleado_Sindicatos]
    FOREIGN KEY ([IDSindicato])
    REFERENCES [dbo].[Sindicatos]
        ([idSindicato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaEmpleado_Sindicatos'
CREATE INDEX [IX_FK_CategoriaEmpleado_Sindicatos]
ON [dbo].[CategoriaEmpleado]
    ([IDSindicato]);
GO

-- Creating foreign key on [idCategoriaEmpleado] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Table_Empleado_Table_CategoriaEmpleado]
    FOREIGN KEY ([idCategoriaEmpleado])
    REFERENCES [dbo].[CategoriaEmpleado]
        ([idCategoriaEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Empleado_Table_CategoriaEmpleado'
CREATE INDEX [IX_FK_Table_Empleado_Table_CategoriaEmpleado]
ON [dbo].[Empleados]
    ([idCategoriaEmpleado]);
GO

-- Creating foreign key on [IdCentroCosto] in table 'Comprobantes'
ALTER TABLE [dbo].[Comprobantes]
ADD CONSTRAINT [FK_Table_Comprobante_Table_CentroCosto]
    FOREIGN KEY ([IdCentroCosto])
    REFERENCES [dbo].[CentroCostos]
        ([IdCentroCosto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Comprobante_Table_CentroCosto'
CREATE INDEX [IX_FK_Table_Comprobante_Table_CentroCosto]
ON [dbo].[Comprobantes]
    ([IdCentroCosto]);
GO

-- Creating foreign key on [IDCombustible] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_Vehiculos_Combustibles]
    FOREIGN KEY ([IDCombustible])
    REFERENCES [dbo].[Combustibles]
        ([IDCombustible])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Vehiculos_Combustibles'
CREATE INDEX [IX_FK_Vehiculos_Combustibles]
ON [dbo].[Vehiculos]
    ([IDCombustible]);
GO

-- Creating foreign key on [IdCondicionCompra] in table 'Comprobantes'
ALTER TABLE [dbo].[Comprobantes]
ADD CONSTRAINT [FK_Table_Comprobante_Table_CondicionCompra]
    FOREIGN KEY ([IdCondicionCompra])
    REFERENCES [dbo].[CondicionesCompra]
        ([IdCondicionCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Comprobante_Table_CondicionCompra'
CREATE INDEX [IX_FK_Table_Comprobante_Table_CondicionCompra]
ON [dbo].[Comprobantes]
    ([IdCondicionCompra]);
GO

-- Creating foreign key on [Contable] in table 'Comprobantes'
ALTER TABLE [dbo].[Comprobantes]
ADD CONSTRAINT [FK_Table_Comprobante_Table_Contable]
    FOREIGN KEY ([Contable])
    REFERENCES [dbo].[Contable]
        ([IdContable])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Comprobante_Table_Contable'
CREATE INDEX [IX_FK_Table_Comprobante_Table_Contable]
ON [dbo].[Comprobantes]
    ([Contable]);
GO

-- Creating foreign key on [IdEstado] in table 'Comprobantes'
ALTER TABLE [dbo].[Comprobantes]
ADD CONSTRAINT [FK_Table_Comprobante_Table_Estados]
    FOREIGN KEY ([IdEstado])
    REFERENCES [dbo].[Estados]
        ([idEstado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Comprobante_Table_Estados'
CREATE INDEX [IX_FK_Table_Comprobante_Table_Estados]
ON [dbo].[Comprobantes]
    ([IdEstado]);
GO

-- Creating foreign key on [IdTipoComprobante] in table 'Comprobantes'
ALTER TABLE [dbo].[Comprobantes]
ADD CONSTRAINT [FK_Table_Comprobante_Table_TipoComprobante]
    FOREIGN KEY ([IdTipoComprobante])
    REFERENCES [dbo].[TiposComprobante]
        ([IdTipoComprobante])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Comprobante_Table_TipoComprobante'
CREATE INDEX [IX_FK_Table_Comprobante_Table_TipoComprobante]
ON [dbo].[Comprobantes]
    ([IdTipoComprobante]);
GO

-- Creating foreign key on [IdTipoFactura] in table 'Comprobantes'
ALTER TABLE [dbo].[Comprobantes]
ADD CONSTRAINT [FK_Table_Comprobante_Table_TipoFactura]
    FOREIGN KEY ([IdTipoFactura])
    REFERENCES [dbo].[TiposFactura]
        ([IdTipoFactura])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Comprobante_Table_TipoFactura'
CREATE INDEX [IX_FK_Table_Comprobante_Table_TipoFactura]
ON [dbo].[Comprobantes]
    ([IdTipoFactura]);
GO

-- Creating foreign key on [idComprobante] in table 'DetallesPago'
ALTER TABLE [dbo].[DetallesPago]
ADD CONSTRAINT [FK_Table_DetallePago_Table_Comprobante]
    FOREIGN KEY ([idComprobante])
    REFERENCES [dbo].[Comprobantes]
        ([IdComprobante])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_DetallePago_Table_Comprobante'
CREATE INDEX [IX_FK_Table_DetallePago_Table_Comprobante]
ON [dbo].[DetallesPago]
    ([idComprobante]);
GO

-- Creating foreign key on [IdComprobante] in table 'DetallesComprobanteArticulos'
ALTER TABLE [dbo].[DetallesComprobanteArticulos]
ADD CONSTRAINT [FK_Table_DetallesComprobanteArticulos_Table_Comprobante]
    FOREIGN KEY ([IdComprobante])
    REFERENCES [dbo].[Comprobantes]
        ([IdComprobante])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_DetallesComprobanteArticulos_Table_Comprobante'
CREATE INDEX [IX_FK_Table_DetallesComprobanteArticulos_Table_Comprobante]
ON [dbo].[DetallesComprobanteArticulos]
    ([IdComprobante]);
GO

-- Creating foreign key on [idDepartamento] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Table_Empleado_Table_Departamento]
    FOREIGN KEY ([idDepartamento])
    REFERENCES [dbo].[Departamentos]
        ([IdDepartamento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Empleado_Table_Departamento'
CREATE INDEX [IX_FK_Table_Empleado_Table_Departamento]
ON [dbo].[Empleados]
    ([idDepartamento]);
GO

-- Creating foreign key on [IdMedioPago] in table 'DetalleMediosPagos'
ALTER TABLE [dbo].[DetalleMediosPagos]
ADD CONSTRAINT [FK_Table_DetalleMediosPago_Table_MedioPago]
    FOREIGN KEY ([IdMedioPago])
    REFERENCES [dbo].[MediosPago]
        ([IdMedioPago])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_DetalleMediosPago_Table_MedioPago'
CREATE INDEX [IX_FK_Table_DetalleMediosPago_Table_MedioPago]
ON [dbo].[DetalleMediosPagos]
    ([IdMedioPago]);
GO

-- Creating foreign key on [IdPago] in table 'DetalleMediosPagos'
ALTER TABLE [dbo].[DetalleMediosPagos]
ADD CONSTRAINT [FK_Table_DetalleMediosPago_Table_Pagos]
    FOREIGN KEY ([IdPago])
    REFERENCES [dbo].[Pagos]
        ([Idpago])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_DetalleMediosPago_Table_Pagos'
CREATE INDEX [IX_FK_Table_DetalleMediosPago_Table_Pagos]
ON [dbo].[DetalleMediosPagos]
    ([IdPago]);
GO

-- Creating foreign key on [IdProductorSeguro] in table 'DetalleProveedor_ProductorSeguro'
ALTER TABLE [dbo].[DetalleProveedor_ProductorSeguro]
ADD CONSTRAINT [FK_Table_DetalleProveedor_ProductorSeguro_Table_ProductorSeguro]
    FOREIGN KEY ([IdProductorSeguro])
    REFERENCES [dbo].[ProductoresSeguro]
        ([IdProductorSeguro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_DetalleProveedor_ProductorSeguro_Table_ProductorSeguro'
CREATE INDEX [IX_FK_Table_DetalleProveedor_ProductorSeguro_Table_ProductorSeguro]
ON [dbo].[DetalleProveedor_ProductorSeguro]
    ([IdProductorSeguro]);
GO

-- Creating foreign key on [IdProveedor] in table 'DetalleProveedor_ProductorSeguro'
ALTER TABLE [dbo].[DetalleProveedor_ProductorSeguro]
ADD CONSTRAINT [FK_Table_DetalleProveedor_ProductorSeguro_Table_Proveedores]
    FOREIGN KEY ([IdProveedor])
    REFERENCES [dbo].[Proveedores]
        ([IdProveedores])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_DetalleProveedor_ProductorSeguro_Table_Proveedores'
CREATE INDEX [IX_FK_Table_DetalleProveedor_ProductorSeguro_Table_Proveedores]
ON [dbo].[DetalleProveedor_ProductorSeguro]
    ([IdProveedor]);
GO

-- Creating foreign key on [IdPago] in table 'DetallesPago'
ALTER TABLE [dbo].[DetallesPago]
ADD CONSTRAINT [FK_Table_DetallePago_Table_Pagos]
    FOREIGN KEY ([IdPago])
    REFERENCES [dbo].[Pagos]
        ([Idpago])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_DetallePago_Table_Pagos'
CREATE INDEX [IX_FK_Table_DetallePago_Table_Pagos]
ON [dbo].[DetallesPago]
    ([IdPago]);
GO

-- Creating foreign key on [IDEmpresaAFectada] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Empleados_EmpresasClientes]
    FOREIGN KEY ([IDEmpresaAFectada])
    REFERENCES [dbo].[EmpresasClientes]
        ([IDEmpresaCliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Empleados_EmpresasClientes'
CREATE INDEX [IX_FK_Empleados_EmpresasClientes]
ON [dbo].[Empleados]
    ([IDEmpresaAFectada]);
GO

-- Creating foreign key on [EstadoCivil] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Empleados_EstadoCivil]
    FOREIGN KEY ([EstadoCivil])
    REFERENCES [dbo].[EstadoCivil]
        ([IDEstadoCivil])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Empleados_EstadoCivil'
CREATE INDEX [IX_FK_Empleados_EstadoCivil]
ON [dbo].[Empleados]
    ([EstadoCivil]);
GO

-- Creating foreign key on [IdLocalidad] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Empleados_Localidades]
    FOREIGN KEY ([IdLocalidad])
    REFERENCES [dbo].[Localidades]
        ([IdLocalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Empleados_Localidades'
CREATE INDEX [IX_FK_Empleados_Localidades]
ON [dbo].[Empleados]
    ([IdLocalidad]);
GO

-- Creating foreign key on [IdNacionalidad] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Empleados_Nacionalidades]
    FOREIGN KEY ([IdNacionalidad])
    REFERENCES [dbo].[Nacionalidades]
        ([IdNacionalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Empleados_Nacionalidades'
CREATE INDEX [IX_FK_Empleados_Nacionalidades]
ON [dbo].[Empleados]
    ([IdNacionalidad]);
GO

-- Creating foreign key on [IdObraSocial] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Empleados_ObraSocial]
    FOREIGN KEY ([IdObraSocial])
    REFERENCES [dbo].[ObraSocial]
        ([idObraSocial])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Empleados_ObraSocial'
CREATE INDEX [IX_FK_Empleados_ObraSocial]
ON [dbo].[Empleados]
    ([IdObraSocial]);
GO

-- Creating foreign key on [IdSexo] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Empleados_Sexos]
    FOREIGN KEY ([IdSexo])
    REFERENCES [dbo].[Sexos]
        ([IDSexo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Empleados_Sexos'
CREATE INDEX [IX_FK_Empleados_Sexos]
ON [dbo].[Empleados]
    ([IdSexo]);
GO

-- Creating foreign key on [IDZona] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Empleados_Zonas]
    FOREIGN KEY ([IDZona])
    REFERENCES [dbo].[Zonas]
        ([IdZona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Empleados_Zonas'
CREATE INDEX [IX_FK_Empleados_Zonas]
ON [dbo].[Empleados]
    ([IDZona]);
GO

-- Creating foreign key on [IDEmpleado] in table 'Mantenimiento'
ALTER TABLE [dbo].[Mantenimiento]
ADD CONSTRAINT [FK_Mantenimiento_Empleados]
    FOREIGN KEY ([IDEmpleado])
    REFERENCES [dbo].[Empleados]
        ([IDEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Mantenimiento_Empleados'
CREATE INDEX [IX_FK_Mantenimiento_Empleados]
ON [dbo].[Mantenimiento]
    ([IDEmpleado]);
GO

-- Creating foreign key on [idEspecialidad] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Table_Empleado_Table_Especialidad]
    FOREIGN KEY ([idEspecialidad])
    REFERENCES [dbo].[Especialidades]
        ([idEspecialidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Empleado_Table_Especialidad'
CREATE INDEX [IX_FK_Table_Empleado_Table_Especialidad]
ON [dbo].[Empleados]
    ([idEspecialidad]);
GO

-- Creating foreign key on [idSindicato] in table 'Empleados'
ALTER TABLE [dbo].[Empleados]
ADD CONSTRAINT [FK_Table_Empleado_Table_Sindicato]
    FOREIGN KEY ([idSindicato])
    REFERENCES [dbo].[Sindicatos]
        ([idSindicato])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Empleado_Table_Sindicato'
CREATE INDEX [IX_FK_Table_Empleado_Table_Sindicato]
ON [dbo].[Empleados]
    ([idSindicato]);
GO

-- Creating foreign key on [IdChofer] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_Vehiculos_Empleados]
    FOREIGN KEY ([IdChofer])
    REFERENCES [dbo].[Empleados]
        ([IDEmpleado])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Vehiculos_Empleados'
CREATE INDEX [IX_FK_Vehiculos_Empleados]
ON [dbo].[Vehiculos]
    ([IdChofer]);
GO

-- Creating foreign key on [EstadoCivil] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [FK_Personas_EstadoCivil]
    FOREIGN KEY ([EstadoCivil])
    REFERENCES [dbo].[EstadoCivil]
        ([IDEstadoCivil])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Personas_EstadoCivil'
CREATE INDEX [IX_FK_Personas_EstadoCivil]
ON [dbo].[Personas]
    ([EstadoCivil]);
GO

-- Creating foreign key on [IdLocalidad] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [FK_Personas_Localidades]
    FOREIGN KEY ([IdLocalidad])
    REFERENCES [dbo].[Localidades]
        ([IdLocalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Personas_Localidades'
CREATE INDEX [IX_FK_Personas_Localidades]
ON [dbo].[Personas]
    ([IdLocalidad]);
GO

-- Creating foreign key on [IDLocalidad] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [FK_Table_Proveedores_Table_Localidades]
    FOREIGN KEY ([IDLocalidad])
    REFERENCES [dbo].[Localidades]
        ([IdLocalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Proveedores_Table_Localidades'
CREATE INDEX [IX_FK_Table_Proveedores_Table_Localidades]
ON [dbo].[Proveedores]
    ([IDLocalidad]);
GO

-- Creating foreign key on [IDLocalidad] in table 'Talleres'
ALTER TABLE [dbo].[Talleres]
ADD CONSTRAINT [FK_Talleres_Localidades]
    FOREIGN KEY ([IDLocalidad])
    REFERENCES [dbo].[Localidades]
        ([IdLocalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Talleres_Localidades'
CREATE INDEX [IX_FK_Talleres_Localidades]
ON [dbo].[Talleres]
    ([IDLocalidad]);
GO

-- Creating foreign key on [IDTaller] in table 'Mantenimiento'
ALTER TABLE [dbo].[Mantenimiento]
ADD CONSTRAINT [FK_Mantenimiento_Talleres]
    FOREIGN KEY ([IDTaller])
    REFERENCES [dbo].[Talleres]
        ([IDTalleres])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Mantenimiento_Talleres'
CREATE INDEX [IX_FK_Mantenimiento_Talleres]
ON [dbo].[Mantenimiento]
    ([IDTaller]);
GO

-- Creating foreign key on [IdVehiculo] in table 'Mantenimiento'
ALTER TABLE [dbo].[Mantenimiento]
ADD CONSTRAINT [FK_Mantenimiento_Vehiculos]
    FOREIGN KEY ([IdVehiculo])
    REFERENCES [dbo].[Vehiculos]
        ([IDVehiculo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Mantenimiento_Vehiculos'
CREATE INDEX [IX_FK_Mantenimiento_Vehiculos]
ON [dbo].[Mantenimiento]
    ([IdVehiculo]);
GO

-- Creating foreign key on [MarcaID] in table 'ModelosVehiculos'
ALTER TABLE [dbo].[ModelosVehiculos]
ADD CONSTRAINT [FK_ModelosVehiculos_MarcasVehiculos]
    FOREIGN KEY ([MarcaID])
    REFERENCES [dbo].[MarcasVehiculos]
        ([IDMarca])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModelosVehiculos_MarcasVehiculos'
CREATE INDEX [IX_FK_ModelosVehiculos_MarcasVehiculos]
ON [dbo].[ModelosVehiculos]
    ([MarcaID]);
GO

-- Creating foreign key on [Marca] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_Vehiculos_MarcasVehiculos]
    FOREIGN KEY ([Marca])
    REFERENCES [dbo].[MarcasVehiculos]
        ([IDMarca])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Vehiculos_MarcasVehiculos'
CREATE INDEX [IX_FK_Vehiculos_MarcasVehiculos]
ON [dbo].[Vehiculos]
    ([Marca]);
GO

-- Creating foreign key on [MenuID] in table 'SubMenus'
ALTER TABLE [dbo].[SubMenus]
ADD CONSTRAINT [FK_SubMenus_Menus]
    FOREIGN KEY ([MenuID])
    REFERENCES [dbo].[Menus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubMenus_Menus'
CREATE INDEX [IX_FK_SubMenus_Menus]
ON [dbo].[SubMenus]
    ([MenuID]);
GO

-- Creating foreign key on [Modelo] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_Vehiculos_ModelosVehiculos]
    FOREIGN KEY ([Modelo])
    REFERENCES [dbo].[ModelosVehiculos]
        ([IDModeloVehiculo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Vehiculos_ModelosVehiculos'
CREATE INDEX [IX_FK_Vehiculos_ModelosVehiculos]
ON [dbo].[Vehiculos]
    ([Modelo]);
GO

-- Creating foreign key on [IdNacionalidad] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [FK_Personas_Nacionalidades]
    FOREIGN KEY ([IdNacionalidad])
    REFERENCES [dbo].[Nacionalidades]
        ([IdNacionalidad])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Personas_Nacionalidades'
CREATE INDEX [IX_FK_Personas_Nacionalidades]
ON [dbo].[Personas]
    ([IdNacionalidad]);
GO

-- Creating foreign key on [UserAltaID] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [FK_Proveedores_AspNetUsers]
    FOREIGN KEY ([UserAltaID])
    REFERENCES [dbo].[NetUser]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Proveedores_AspNetUsers'
CREATE INDEX [IX_FK_Proveedores_AspNetUsers]
ON [dbo].[Proveedores]
    ([UserAltaID]);
GO

-- Creating foreign key on [idObraSocial] in table 'Personas'
ALTER TABLE [dbo].[Personas]
ADD CONSTRAINT [FK_Personas_ObraSocial]
    FOREIGN KEY ([idObraSocial])
    REFERENCES [dbo].[ObraSocial]
        ([idObraSocial])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Personas_ObraSocial'
CREATE INDEX [IX_FK_Personas_ObraSocial]
ON [dbo].[Personas]
    ([idObraSocial]);
GO

-- Creating foreign key on [IDPersona] in table 'Referencias'
ALTER TABLE [dbo].[Referencias]
ADD CONSTRAINT [FK_Referencias_Personas]
    FOREIGN KEY ([IDPersona])
    REFERENCES [dbo].[Personas]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Referencias_Personas'
CREATE INDEX [IX_FK_Referencias_Personas]
ON [dbo].[Referencias]
    ([IDPersona]);
GO

-- Creating foreign key on [idPersona] in table 'SolicitudesEmpleo'
ALTER TABLE [dbo].[SolicitudesEmpleo]
ADD CONSTRAINT [FK_SolicitudesEmpleo_Personas]
    FOREIGN KEY ([idPersona])
    REFERENCES [dbo].[Personas]
        ([IdPersona])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SolicitudesEmpleo_Personas'
CREATE INDEX [IX_FK_SolicitudesEmpleo_Personas]
ON [dbo].[SolicitudesEmpleo]
    ([idPersona]);
GO

-- Creating foreign key on [IdPolizaSeguro] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_Vehiculos_PolizasSeguro]
    FOREIGN KEY ([IdPolizaSeguro])
    REFERENCES [dbo].[PolizasSeguro]
        ([IDPolizaSeguro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Vehiculos_PolizasSeguro'
CREATE INDEX [IX_FK_Vehiculos_PolizasSeguro]
ON [dbo].[Vehiculos]
    ([IdPolizaSeguro]);
GO

-- Creating foreign key on [IDProfile] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_Users_Profiles]
    FOREIGN KEY ([IDProfile])
    REFERENCES [dbo].[Profiles]
        ([Id_Profiles])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Users_Profiles'
CREATE INDEX [IX_FK_Users_Profiles]
ON [dbo].[Users]
    ([IDProfile]);
GO

-- Creating foreign key on [IdProveedores] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [FK_Proveedores_Proveedores]
    FOREIGN KEY ([IdProveedores])
    REFERENCES [dbo].[Proveedores]
        ([IdProveedores])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IDRubro] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [FK_Proveedores_RubroProveedor]
    FOREIGN KEY ([IDRubro])
    REFERENCES [dbo].[RubroProveedor]
        ([IDRubroProveedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Proveedores_RubroProveedor'
CREATE INDEX [IX_FK_Proveedores_RubroProveedor]
ON [dbo].[Proveedores]
    ([IDRubro]);
GO

-- Creating foreign key on [IDProvincia] in table 'Proveedores'
ALTER TABLE [dbo].[Proveedores]
ADD CONSTRAINT [FK_Table_Proveedores_Table_Provincias]
    FOREIGN KEY ([IDProvincia])
    REFERENCES [dbo].[Provincias]
        ([IDProvincias])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Proveedores_Table_Provincias'
CREATE INDEX [IX_FK_Table_Proveedores_Table_Provincias]
ON [dbo].[Proveedores]
    ([IDProvincia]);
GO

-- Creating foreign key on [IdTipoTaller] in table 'Talleres'
ALTER TABLE [dbo].[Talleres]
ADD CONSTRAINT [FK_Talleres_TipoTaller]
    FOREIGN KEY ([IdTipoTaller])
    REFERENCES [dbo].[TipoTaller]
        ([IdTipoTaller])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Talleres_TipoTaller'
CREATE INDEX [IX_FK_Talleres_TipoTaller]
ON [dbo].[Talleres]
    ([IdTipoTaller]);
GO

-- Creating foreign key on [IDVehiculo] in table 'Vehiculos'
ALTER TABLE [dbo].[Vehiculos]
ADD CONSTRAINT [FK_Vehiculos_Vehiculos]
    FOREIGN KEY ([IDVehiculo])
    REFERENCES [dbo].[Vehiculos]
        ([IDVehiculo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NetRoles_Id] in table 'NetUsersRoles'
ALTER TABLE [dbo].[NetUsersRoles]
ADD CONSTRAINT [FK_NetUsersRoles_NetRoles]
    FOREIGN KEY ([NetRoles_Id])
    REFERENCES [dbo].[NetRoles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NetUser_Id] in table 'NetUsersRoles'
ALTER TABLE [dbo].[NetUsersRoles]
ADD CONSTRAINT [FK_NetUsersRoles_NetUser]
    FOREIGN KEY ([NetUser_Id])
    REFERENCES [dbo].[NetUser]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NetUsersRoles_NetUser'
CREATE INDEX [IX_FK_NetUsersRoles_NetUser]
ON [dbo].[NetUsersRoles]
    ([NetUser_Id]);
GO

-- Creating foreign key on [RetencionID] in table 'Pagos'
ALTER TABLE [dbo].[Pagos]
ADD CONSTRAINT [FK_Pagos_Retenciones]
    FOREIGN KEY ([RetencionID])
    REFERENCES [dbo].[Retenciones]
        ([IDRetencion])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Pagos_Retenciones'
CREATE INDEX [IX_FK_Pagos_Retenciones]
ON [dbo].[Pagos]
    ([RetencionID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------