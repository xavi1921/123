   M S B A M L   `   `   `  ����I  EFONET_CIA_LTDA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:FONET_CIA_LTDA.PresentacionFONET_CIA_LTDA.Presentacion  5   	   :    4FONET_CIA_LTDA.Presentacion.InsertarContratoServicio   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5local)clr-namespace:FONET_CIA_LTDA.Presentacion  5   	     � Title$#  INSERTAR CONTRATO DE SERVICIO��5	   	   $	��365��6/   $	��483��6<    � 
ResizeMode$ NoResize=�6I    � WindowStartupLocation$ CenterScreen=�6_   .��5
      � $	��317��6   $��0,0,0.333,0q�6   $	��Top=�6-   .+�5   
   �� -   5         ��Name$ 	txtCedula��5       �� 
IsReadOnly .  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cédula del cliente��68      
IsFloating .  �� 	MaxLength$ 10��6�   $��32,53,326,214q�6�   �� 5   
   -   5         ��Name$ 
btnGuardar��5      $��Guardar��6%   $
��Left=�67   $��
32,272,0,0q�6R   $	��Top=�6f   
���  ��
���  ��
��� ���6�   �� 5   
   -   5        $ btnCancelar��5         MaterialDesignFlatButton#���   6&   $��Cancelar��6e   $
��Left=�6x   $��149,272,0,0q�6�   $	��Top=�6�   
���  ��6�   �� 5   
   -   5        	 ��Name$	 	lblTitulo��5      $@��:Seleccione un cliente y una fecha de instalación agendada��6#   $
��Left=�6g   $��	32,10,0,0q�6�   $	��Top=�6�   �� 5   
   -   5        
 ��Name$
 
txtBoxPlan��5      $" Seleccionar el plan de Megas��6'    . $��32,166,265,101q�6�   $��50��6�   �� 5   
   -   5        $ txtIdInstalacion��5       .  $ Codigo Instalación��6?    . $��32,108,272,156q�6�   5      5      