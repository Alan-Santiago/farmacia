   M S B A M L   `   `   `  ����C  ?farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:farmaciafarmacia  5   	       farmacia.venta   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:farmacia     5   	     � Title$  venta��5   	   $	��350��6   $	��300��6$   ���	#FF97FDEF.��5	      �  � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��20(�6   $��Center=�6   $��0��6;   $��Engravers MT)�6H   .��6b   Venta6i   � 5   
   $��1��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   	Empleado*6S   �� 5      -   5         ��Name$ txbEmpleado��5      $	��200��6/   6=   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   
Cliente*6R   �� 5      -   5        $ 
txbCliente��5      $	��200��6.   6<   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   
Categoria*6T   �� 5      -   5        $ txbCategoria��5      $	��200��60   6>   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   	Producto*6S   �� 5       -   5        $ txbProducto��5       $	��200��6/   6=   5!      �� 5"      $ 
Horizontal=�6   .+�5#      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   Fecha*6P   �� 5$      -   5        $ txbFecha��5$      $	��200��6,   6:   5%      �� 5&      $ 
Horizontal=�6   .+�5'      �� $��80��6   $��Arial)�6#   $
��Bold"�66   .��6H   Total*6P   �� 5(      -   5        $ txbTotal��5(      $	��200��6,   6:   5)      �� 5*      $
��Bold"�6   $��9(�6&   .��63   *=Campos obligatorios6J   5+      � 5,   
   $��2��6   .+�5.      �� -   5         ��Name$ 
btnGuardar��5.   !   $	��120��6   .��6N   	Guardar6W   �� 5/      -   5        $ 	btnEditar��5/   !   $	��120��6   .��6L   Editar6T   50      &   System.Windows.Controls.DataGrid  51   
   -	   5          Name$ dtgTabla��51         
IsReadOnly . $��3��67   ���	#FF8BF9EA6D   52      53      