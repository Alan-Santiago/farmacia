   M S B A M L   `   `   `  ����C  ?farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:farmaciafarmacia  5   	       farmacia.producto   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:farmacia     5   	     � Title$  producto��5   	   $	��360��6   $	��380��6'   ���	#FF8FF9EB.��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��20(�6   $��Center=�6   $��0��6;   $��Engravers MT)�6H   .��6b   
Producto6l   � 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   
Nombre *6R   �� 5      -   5         ��Name$ 	txbNombre��5      $	��200��6-   6;   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��90��6   $��Arial)�6#   $
��Bold"�66   .��6H   Descripcion*6V   �� 5      -   5        $ txbDescripcion��5      $	��200��62   6@   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��120��6   $��Arial)�6$   $
��Bold"�67   .��6I   Precio De Compra*6\   �� 5      -   5        $ txbPrecioDeCompra��5      $	��200��65   6C   5      �� 5      $ 
Horizontal=�6   .+�5      �� $	��120��6   $��Arial)�6$   $
��Bold"�67   .��6I   PrecioDeVenta*6Y   �� 5       -   5        $ txbPrecioDeVenta��5       $	��200��64   6B   5!      �� 5"      $ 
Horizontal=�6   .+�5#      �� $��90��6   $��Arial)�6#   $
��Bold"�66   .��6H   Presentacion*6W   �� 5$      -   5        $ txbPresentacion��5$      $	��200��63   6A   5%      �� 5&      $ 
Horizontal=�6   .+�5'      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   
Categoria*6T   �� 5(      -   5        $ txbCategoria��5(      $	��200��60   6>   5*      �� 5+      $
��Bold"�6   $��9(�6&   .��63   *=Campos obligatorios6J   5,      � 5-   
   $��2��6   .+�5.      �� -   5         ��Name$ btnNuevo��5.       $��70��6   .��6I   Nuevo6P   �� 5/      -   5        $ 
btnGuardar��5/       $��70��6   .��6M   	Guardar6V   �� 50      -	   5        $ 	btnEditar��50       $��70��6   .��6K   Editar6S   �� 51      -
   5        $ btnCancelar��51       $��70��6   .��6O   
Cancelar6Y   �� 52      -   5        $ btnEliminar��52       $��70��6   .��6O   
Eliminar6Y   �� 53      -   5        $ btnSalir��53       $��70��6   .��6I   Salir6P   54      &   System.Windows.Controls.DataGrid  55   
   -   5          Name$ dtgTabla��55         
IsReadOnly . $��3��67   ���	#FF94FBED6D   57      58      