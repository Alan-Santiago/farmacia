   M S B A M L   `   `   `  ����C  ?farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:farmaciafarmacia  5   	       farmacia.empleado   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:farmacia     5   	     � Title$  empleado��5   	   $	��350��6   $	��300��6'   ���	#FF99F7EF.��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��20(�6   $��Center=�6   $��0��6;   $��Engravers MT)�6H   .��6b   
Empleado6l   � 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   
Nombre *6R   �� 5      -   5         ��Name$ 	txbNombre��5      $	��200��6-   6;   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   
Direccion*6T   �� 5      -   5        $ txbDireccion��5      $	��200��60   6>   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   	Telefono*6S   �� 5      -   5        $ txbTelefono��5      $	��200��6/   6=   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   Area*6O   �� 5       -   5        $ txbArea��5       $	��200��6+   69   5!      �� 5"      $ 
Horizontal=�6   .+�5#      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   	Correo*6Q   �� 5$      -   5        $ 	txbCorreo��5$      $	��200��6-   6;   5%      �� 5&      $
��Bold"�6   $��9(�6&   .��63   *=Campos obligatorios6J   5'      � 5(   
   $��2��6   .+�5)      �� -   5         ��Name$ 
btnGuardar��5)       $��70��6   .��6M   	Guardar6V   �� 5*      -   5        $ btnNuevo��5*       $��70��6   .��6I   Nuevo6P   �� 5+      -   5        $ 	btnEditar��5+       $��70��6   .��6K   Editar6S   �� 5,      -	   5        $ btnCancelar��5,       $��70��6   .��6O   
Cancelar6Y   �� 5-      -
   5        $ btnEliminar��5-       $��70��6   .��6O   
Eliminar6Y   �� 5.      -   5        $ btnSalir��5.       $��70��6   .��6I   Salir6P   5/      &   System.Windows.Controls.DataGrid  50   
   -   5          Name$ dtgTabla��50         
IsReadOnly . $��3��67   ���	#FF8EF7EE6D   51      52      