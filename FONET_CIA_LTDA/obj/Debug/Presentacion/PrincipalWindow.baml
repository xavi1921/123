   M S B A M L   `   `   `  ����  FONET_CIA_LTDA1    +FONET_CIA_LTDA.Presentacion.PrincipalWindow   5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	   	   @d2http://schemas.microsoft.com/expression/blend/2008     5
   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   
�������$��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	   
���  ��  � Title$  FONET��5   	   $	��586��6   $	��851��6$    � WindowStartupLocation$ CenterScreen=�60    � WindowStyle$ ThreeDBorderWindow=�5   	   $��0q�6*    � AllowsTransparency .  $	��286��5   	   $	��660��6   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��512* �6   .+�5   
   � -   5        $��0��5      .+�5      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Light=�6'   
�������$��55��6G   $��0q�6S   $��Stretch=�6g   $��0,0,0,0q�6�   .��5      � $��Stretch=�6   $��50��66   $��Bottom=�6B    � ColumnDefinitions 5      �� 5      $
��500* �6+   �� 5      $
��100* �6+   �� 5      $��80 �6+   .+�5      �� -   5         ��Name$ 	lblTitulo��5      
���   �$��CARGANDO...��6B   $��10,0,0,0q�6X   $��Center=�6k   $
��Left=�6�   $��24(�6�   $��Normal"�6�   �� 5       -   5        $ lblTipoUsuario��5       $��1��65   $��0��6E   $��0,0,0,0q�6Q   $y�Hidden=�6b   $��Center=�6w   $��Right=�6�   $��20(�6�   
���   �$��Normal"�6�   �� 5"      -   5        $ 
lblUsuario��5"      $��1��61   $��usuario��6A   $��0,0,0,0q�6S   $��Center=�6e   $��Right=�6�   $��20(�6�   
���   �$��Normal"�6�   '  !MaterialDesignThemes.Wpf.PackIcon  5#         Kind$
 User=�6.   $��2��6:   $��0,0,40,0q�6J   
���  ��$��Center=�6r   $��Right=�6�   $��30��6�   $��30��6�   �� 5$      -   5        	 ��Name$	 cerrarSesion��5$      $��2��64   
������ $��Center=�6]   $��Right=�6x   $��30��6�   $��30��6�   
 � Cursor$

 Hand��6�   ��6�   Z� ��6�   Z�   5%      $ Shutdown=�6.   $��2��6>   $��0,0,5,0q�6N    J� IsHitTestVisible .  
���  ��$��Center=�6�   $��Right=�6�   $��30��6�   $��30��6�   $

 Hand��6�   5&      5(      5)       � 5+   
   -   5          �Name$ frame1��5+      $��0q�6    $��0q�6,   $�� ��6@     � Source$; 5/FONET_CIA_LTDA;component/Presentacion/AdminPage.xaml?�6K   $��Stretch=�6�   $��Stretch=�6�     � NavigationUIVisibility$ Hidden=�6�   $��2��6�   
�������6$  )  #MaterialDesignThemes.Wpf.DialogHost  5-   
   -   5          Name$ salir��5-   3      IsOpen .  $��3��6B   $��0q�6S      DialogContent 5.      �� 5/      $��20q�6    �� Orientation$ Vertical=�6)   .+�50      �� $��¿Desea cerrar sesión?��6    �� 51      -   5        $	 	btnCerrar��51      {�. $��Si��6A   $��90��6O   $��0,20,0,0q�6Z   
���  ��
��� ���6�   �� 52      -	   5        $	 btnNoCerrar��52      {�. $��NO��6C   $��90��6Q   $��0,20,0,0q�6\   
�������
���  ��6�   53      55        57   
   -
   5        $ cargando��57   3    .  $��3��6E   $��0q�6V    58      �� 59      $��20q�6   $ Vertical=�6)   .+�5:      �� $��Cargando datos....��6    5;      5=      %  MaterialDesignThemes.Wpf.Badged  5>   
   $��Badged��6    $
��Left=�61   $	��126��6L   $��381,601,0,-220.333q�6Y   $��1��6u   $	��Top=�6�   $��15��6�   5?      5B      