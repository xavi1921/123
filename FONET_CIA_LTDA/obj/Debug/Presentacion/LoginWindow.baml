   M S B A M L   `   `   `  ����  FONET_CIA_LTDA-    'FONET_CIA_LTDA.Presentacion.LoginWindow   5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   
�������$��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	      MaterialDesignBody#���   5   	   $��1q�5   	   
���  ��  � Title$  Login��5   	   $	��420��6   $	��425��6$    � WindowStyle$
 None=�60    � AllowsTransparency .  � WindowStartupLocation$ CenterScreen=�6]    � 
ResizeMode$ NoResize=�6�   .��5      � $��0,0,0,0q�6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��120 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost  -   5          Name$ 
errorLogin��5   3      IsOpen .  $��3��6G   $��2��6X   	   DialogContent	 5      �� 5      $��20q�6   
 �� Orientation$
 Vertical=�6)   .+�5      �� $&�� Contraseña o Usiario incorrecto��6    �� 5       -   5         ��Name$ btnError��5       {�. $��Aceptar��6@   $��90��6S   $��0,20,0,0q�6^   6p   5!      5#      �� 5$   
   -   5        $��0��5$      $��2��6   
������ ._�5%      � .+�5&      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ Light=�6+   .��5'      �� $��Right=�6!   .+�5(      �� -   5        $ btnClose��5(   !   $��30��63   $��30��6>   
���  ��+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�6_   $��0q�6�   .��5)      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ WindowClose=�66   
��� ���
���  ��6]   5*      5+      5-      5.      5/      � 50   
   $��1��6   .+�51        $ Light=�6'   $��Center=�64   .��52      �� $��
BIENVENIDO��6   $��30(�6.   $
��Left=�6<   $��Center=�6W   $��
30 20 0 10q�6r   54      55      � 56   
   $��1��6   $��1��6   .+�57      �� -   5         ��Name$ imgLogin��57      58      � 59   
   $��2��6   $��2��6   $��0,0,0,0q�60   .+�5:      �� $
 Vertical=�6   $��
40,20,0,54q�60   .+�5;      �� $
 
Horizontal=�6   .+�5<        $ Account=�6.   $��Bottom=�6w   $��6q�6�   ��6=   �� *BorderBrush+ �� ElementName$ 	txt_Clave��6�   �� 5=      -   5         ��Name$ txt_Usuario��5=      $	��300��63   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Usuario��6?      
IsFloating . 6h   5>      �� 5?      $
 
Horizontal=�6   $��0 40 0 0q�66   .+�5@        $	 Key=�6.   $��Bottom=�6s   $�� 6q�6�   ��69   �� *BorderBrush+$ 	txt_Clave��6�   G� 5A      -   5         G�Name$ 	txt_Clave��5A   "   $	��300��65   $ Contraseña��6A    . 6m   5B      �� 5C      -   5        $ btnIngresar��5C      $��Ingresar��6.   $��90��6A   $��
150,20,0,0q�6L   
���  ��
��� ���6�   5D      �� 5E      -	   5        $!��¿Se olvido la contraseña?��5E      $��Center=�69   $��Bottom=�6V   $��30q�6q   
������� � Cursor$
 Hand��6�   6�   5F      5G      5H      