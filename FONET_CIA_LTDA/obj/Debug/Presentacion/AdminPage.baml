   M S B A M L   `   `   `  ����  FONET_CIA_LTDA+    %FONET_CIA_LTDA.Presentacion.AdminPage   5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null6dragablz'http://dragablz.net/winfx/xaml/dragablz  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5
      @d2http://schemas.microsoft.com/expression/blend/2008     5      $��Medium"�5      $��14(�5        N� 
FontFamily$X  Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5       N� Title$ AdminComponentes��5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��408* �6   �� 5      $��60 �6    � ColumnDefinitions 5   
   �� 5      $	��135 �6   �� 5      $	��110 �6   �� 5      $	��135 �6   �� 5      $	��70* �6   �� 5      $��55 �6   .+�5   
     Dragablz.TabablzControl  -   5          Name$ tabOpciones��5   "   $��0��67   $��5��6G    �� TabStripPlacement$	 Top=�6[   $��Stretch=�6t   
�������
���   �$��Center=�6�   $��0q�6
  .@�5      �� $��Clientes��6   $��50��6(   .��5       &   System.Windows.Controls.DataGrid  -   5          Name$ dtgClientes��5       $
��10,0q�60      
IsReadOnly .  $��0,0,1.667,-2q�6R      CanUserAddRows .  ��6   Z� 5!      �� 5"      $��Instalación��6   $��50��6,   .��5#        -   5        $ dtgintalacion��5#      $
��10,0q�62    .  $��0,0,-2.333,0q�6T    .  ��6�   Z� 5$      �� 5%      $��	Contratos��6   $��50��6)   .��5&        -   5        $ dtgContratos��5&      $
��10,0q�61    .  $��0,0,1.667,-2q�6S    .  ��6�   Z� 5'      �� 5(      $��Fechas de Pago��6   $��50��6/   .��5)        -   5        $ dtgPagos��5)      $
��10,0q�6-    .  $��0,0,-2.333,0q�6O    .  ��6|   Z� 5*      �� 5+      $��Cortes y reconexiones��6   $��50��65   .��5,        -   5        $ 	dtgCortes��5,      $
��10,0q�6.    .  $��0,0,0.667,-1q�6P    .  ��6}   Z� 5-      �� 5.      $��
Plan Megas��6   $��50��6+   .��5/        -   5        $ dtgPlanMegas��5/      $
��10,0q�61    .  $��0,0,-2.333,0q�6S    .  ��6�   Z� 50      �� 51      $��Facturas��6   .��52        -   5        $ dtgfacturas��52      $
��10,0q�60    .  $��0,0,1.667,-3q�6R    .  ��6   Z� 53      �� 54      $��Usuarios/Empleados��6   .��55        -	   5        $ dtgUsuarios��55      $
��10,0q�60    .  $��0,0,1.667,-3q�6R    .  ��6   Z� 56      57      �� 59   
   -
   5        	 ��Name$	 btnInsertar��59      $��1��6&   $��0��63   $��Insertar��6C   $��Center=�6V   $��Center=�6t   $	��109��6�   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   
���  ��
��� ���
���  ��6�   �� 5:   
   -   5        $	 btnActualizar��5:      $��1��6(   $��1��65   $��
Actualizar��6E   $��Center=�6Z   $��Center=�6w   $	��109��6�   $
 0.5,0.5&�6�   
���  ��
��� ���
���  ��6�   �� 5;   
   -   5        $	 btneliminar��5;      $��1��6&   $��2��63   $��Eliminar��6C   $��Center=�6V   $��Center=�6t   $	��109��6�   
�������
���  ��6�   �� 5=   
   $��Recargar��6   $��1��6#   $��3��60   $��Right=�6@   $��0q�6\   $��Center=�6h   �� 5>   
   -   5        $	 RecargarCargarDatos��5>      $��1��6.   $��4��6;   $��Center=�6K   $��Center=�6h   $��30��6�   $��30��6�   $��0q�6�   
�������$��0q�6�   .��5?      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Refresh=�6&   
���  ��$��30��6J   $��30��6V   5@      �� 5B   
   -   5         ��Name$ lblAdmin��5B      $y�Hidden=�6"   $
��Left=�66   $��620,4.333,0,0q�6Q   $	��Top=�6h   $��30��6�   $��49��6�   $��1��6�   )  #MaterialDesignThemes.Wpf.DialogHost  5D   
   -   5          Name$ msgEliminar��5D   3      IsOpen .  $��3��6H   $��5��6Y   $��0q�6m      DialogContent 5E      �� 5F      $��20q�6    �� Orientation$ Vertical=�6)   .+�5G      �� $%��¿Desea eliminar este elemento?��6    �� 5H      -   5        $	 btnSiEliminar��5H      {�. $��Si��6E   $��90��6S   $��0,20,0,0q�6^   
���  ��
��� ���6�   �� 5I      -   5        $	 btnNoEliminar��5I      {�. $��NO��6E   $��90��6S   $��0,20,0,0q�6^   
�������
���  ��6�   5J      5L      5M      5N      