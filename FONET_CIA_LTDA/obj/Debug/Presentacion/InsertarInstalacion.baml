   M S B A M L   `   `   `  ����I  EFONET_CIA_LTDA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:FONET_CIA_LTDA.PresentacionFONET_CIA_LTDA.Presentacion  5   	   5    /FONET_CIA_LTDA.Presentacion.InsertarInstalacion   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   5local)clr-namespace:FONET_CIA_LTDA.Presentacion  5   	     � Title$%  INSERTAR INSTALACIÓN EN AGENDA��5	   	   $	��300��60   $	��483��6=    � 
ResizeMode$ NoResize=�6J    � WindowStartupLocation$ CenterScreen=�6`   .��5
      � $	��218��6   $	��Top=�6   .+�5   
   �� -   5         ��Name$ 	txtCedula��5       �� 
IsReadOnly .  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Cedula Cliente��68      
IsFloating . $��37,48,272.333,126q�6�    �� 	MaxLength$ 10��6�   �� 5   
   -   5         ��Name$ 	lblTitulo��5      $��Agendar��6#   $
��Left=�65   $��	37,11,0,0q�6P   $	��Top=�6c   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 fechaInstalacion��5      $ Fecha de Instalación��6/      MaterialDesignDatePicker#���   6e    . $��253,48,47.333,126q�6�   $��44��6�   �� 5   
   -   5        
 ��Name$
 txtBoxEstadoInstalacion��5        MaterialDesignComboBox#���  64   $ Estado de instalación��6q    . $��37,97,269.333,77q�6�   $��44��6�   .@�5      �� $��	Pendiente��6   �� 5      $��	Instalado��6   5      �� 5   
   -   5        $ txtObservaciones��5       .  $ Observaciones��6?    . $��37,146,47.333,28q�6�   $ 50��6�   �� 5   
   -   5         ��Name$ 
btnGuardar��5      $��Guardar��6%   $
��Left=�67   $��37,211,0,-25q�6R   $	��Top=�6h   
���  ��
���  ��
��� ���6�   �� 5   
   -   5        $ btnCancelar��5        MaterialDesignFlatButton#���  6&   $��Cancelar��6e   $
��Left=�6x   $��151,211,0,-25q�6�   $	��Top=�6�   
���  ��6�   �� 5   
   -   5        $ btnBuscarCliente��5      #���  6,   $
��Left=�6k   $��
183,67,0,0q�6�   $	��Top=�6�   $��23��6�   $��22��6�   $��0q�6�   
�������$��0q�6	  .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Search=�6&   
���  ��$��19��6I   $��19��6U   5      5      5      