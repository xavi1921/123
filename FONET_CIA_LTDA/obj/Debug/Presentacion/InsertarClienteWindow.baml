   M S B A M L   `   `   `  ����  FONET_CIA_LTDA7    1FONET_CIA_LTDA.Presentacion.InsertarClienteWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  INSERTAR CLIENTE��5   	   $��389.407��6"   $��546.237��63    � 
ResizeMode$ NoResize=�6D    � WindowStartupLocation$ CenterScreen=�6Z   .��5	      � $	��364��6   $��0,0,0,-4q�6   $	��Top=�6*    � RowDefinitions 5
   
   �� 5      $
��323* �6   �� 5      $	��41* �6   .+�5   
   �� -   5         ��Name$ 	txtCedula��5       �� 
IsReadOnly .  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cedula��68      
IsFloating . $��37,61,296,208.468q�6�    �� 	MaxLength$ 10��6�   	 � 
InputScope$	 Number��6�   6�   �� 5   
   -   5        $ 
txtNombres��5      $ Nombres��6'    . $��36,115,306,155.468q�6|   $ 50��6�   �� 5   
   -   5        $ txtApellidos��5      $ 	Apellidos��6)    . $��37,168,306,103.468q�6�   $ 50��6�   �� 5   
   -   5        
 ��Name$
 
btnGuardar��5      $��Guardar��6%   $
��Left=�67   $��
34,301,0,0q�6R   $	��Top=�6f   
���  ��
���  ��
��� ���$��2��6�   �� 5   
   -   5        $
 btnCancelar��5         MaterialDesignFlatButton#���   6&   $��Cancelar��6e   $
��Left=�6x   $��148,301,0,0q�6�   $	��Top=�6�   
���  ��$��2��6�   �� 5   
   -   5         ��Name$ 	lblTitulo��5      $��INSERTAR��6#   $
��Left=�66   $��	34,11,0,0q�6Q   $	��Top=�6d   �� 5   
   -   5        $ txtDireccion��5      $ 
Dirección��6)    . $��249,62,84,208.468q�6�   $ 50��6�   �� 5   
   -   5        $ 	txtCorreo��5      $ Correo��6&    . $��251,168,84,103.468q�6z   $ 50��6�   �� 5   
   -	   5        $ 
txtTelefon��5      $ 	Teléfono��6'    . $��250,115,84,155.468q�6}   $ 10��6�   $	 Number��6�   6�   �� 5   
   -
   5        $ txtReferencia��5      $ 
Referebcua��6*    . $��37,225,306,46.468q�6�   $ 50��6�   �� 5   
   -   5        $ txtCoordenadas��5      $ Coordenadas��6+    . $��246,225,84,46.468q�6�   $ 50��6�   �� 5   
   -   5        $ txtNrContratoy��5       .  $ 
# Contrato��6=    . $��323,8,10,261.468q�6�   $ 10��6�   $	 Number��6�   6�   5      5      