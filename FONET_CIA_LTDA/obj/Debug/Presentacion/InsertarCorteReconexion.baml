   M S B A M L   `   `   `  ����I  EFONET_CIA_LTDA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:FONET_CIA_LTDA.PresentacionFONET_CIA_LTDA.Presentacion  5   	   9    3FONET_CIA_LTDA.Presentacion.InsertarCorteReconexion   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5local)clr-namespace:FONET_CIA_LTDA.Presentacion  5   	     � Title$"  INSERTAR CORTE O RECONEXIÓN��5	   	   $��286.875��6-   $	��483��6>    � 
ResizeMode$ NoResize=�6K    � WindowStartupLocation$ CenterScreen=�6a   .��5
      � $	��250��6   $��0,0,0.333,0q�6   $	��Top=�6-   .+�5   
   �� -   5         ��Name$ 	txtCedula��5       �� 
IsReadOnly .  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cedula Cliente��68      
IsFloating . $��37,40,268.667,163q�6�   �� 5   
   -   5        $ txtObservaciones��5      $ Observaciones��6-    . $��36,92,267.667,113q�6�   �� 5   
   -   5         ��Name$ 
btnGuardar��5      $��Guardar��6%   $
��Left=�67   $��
37,190,0,0q�6R   $	��Top=�6f   
���  ��
���  ��
��� ���6�   �� 5   
   -   5        $ btnCancelar��5         MaterialDesignFlatButton#���   6&   $��Cancelar��6e   $
��Left=�6x   $��152,190,0,0q�6�   $	��Top=�6�   
���  ��6�   �� 5   
   -   5         ��Name$ 	lblTitulo��5      $��INSERTAR��6#   $
��Left=�66   $��	37,11,0,0q�6Q   $	��Top=�6d   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 
fechaCorte��5      $ Fecha de Corte��6)    . $��250,40,50,163q�6�   $��47��6�     5   
   -   5        $	 fechaReconexion��5      $ Fecha de Reconexión��6.    . $��250,92,47,111q�6�   $��47��6�   5      5      