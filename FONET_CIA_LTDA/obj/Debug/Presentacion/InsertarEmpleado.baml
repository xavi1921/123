   M S B A M L   `   `   `  ����I  EFONET_CIA_LTDA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:FONET_CIA_LTDA.PresentacionFONET_CIA_LTDA.Presentacion  5   	   2    ,FONET_CIA_LTDA.Presentacion.InsertarEmpleado   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5local)clr-namespace:FONET_CIA_LTDA.Presentacion  5   	     � Title$  INSERTAR EMPLEADO��5	   	   $��396.25��6#   $	��483��63    � 
ResizeMode$ NoResize=�6@    � WindowStartupLocation$ CenterScreen=�6V   .��5
      � $	��345��6   $	��Top=�6   .+�5   
   �� -   5         ��Name$ 	txtCedula��5       �� 
IsReadOnly .  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cedula��68      
IsFloating . $��37,38,269,258q�6�   �� 5   
   -   5        $ 
txtNombres��5      $ Nombres��6'    . $��36,92,268,205q�6|   �� 5   
   -   5        $ txtApellidos��5      $ 	Apellidos��6)    . $��37,145,264,153q�6�   �� 5   
   -   5         ��Name$ 
btnGuardar��5      $��Guardar��6%   $
��Left=�67   $��
32,302,0,0q�6R   $	��Top=�6f   
���  ��
���  ��
��� ���6�   �� 5   
   -   5        $ btnCancelar��5         MaterialDesignFlatButton#���   6&   $��Cancelar��6e   $
��Left=�6x   $��149,300,0,0q�6�   $	��Top=�6�   
���  ��6�   �� 5   
   -   5         ��Name$ 	lblTitulo��5      $��INSERTAR��6#   $
��Left=�66   $��	37,11,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5        $ txtDireccion��5      $ 
Dirección��6)    . $��249,39,53,258q�6�   �� 5   
   -   5        $ 	txtCorreo��5      $ Correo��6&    . $��251,145,48,153q�6z   �� 5   
   -	   5        $ 
txtTelefon��5      $ 	Teléfono��6'    . $��250,92,48,205q�6}   �� 5   
   -
   5        	 ��Name$	 txtBoxCargos��5      $��250,201,48,111q�6)   $��33��6A   .@�5      �� 
 �� 
IsSelected
 . $��Seleccionar Cargo��6-   �� 5      $��Gerente General��6   �� 5      $��Tecnico��6   �� 5      $��Secretaria/o��6   5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ fechaNacimiento��5      $ Fecha de Nacimiento��6.   $��37,203,264,110q�6c   $��32��6{     5   
   -   5        $ fechaContrato��5      $ Fecha de Contrato��6,   $��250,237,47.667,51q�6_   $��29��6z   G� 5   
   -   5        $��txtPassword��5   \   $ Contraseña...��6   $��40,240,268,65q�6E    ) %MaterialDesignFloatingHintPasswordBox#��[ 6o   $��Champagne & Limousines)�6�   $��14(�6�   5      5      