   M S B A M L   `   `   `  ����C  ?farmacia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:farmaciafarmacia  5   	       farmacia.categoria   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:farmacia     5   	     � Title$  	categoria��5   	   $	��250��6   $��309.173��6(   ���	#FFA8EEDB.��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��106* �6   �� 5      $	��42* �6   �� 5      $
��153* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��20(�6   $��Center=�6   $��0��6;   $��Engravers MT)�6H   $��3��6b   ���	#FFA3E8DF.��6�   Agregar Categoria6�   � 5   
   $��1��6   $��3��6!   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��80��6   $��Global Sans Serif)�6#   $
��Bold"�6B   .��6T   
Nombre *6^   �� 5      -   5         ��Name$ 	txbNombre��5      $	��200��6-   6;   5      �� 5      $
��Bold"�6   $��9(�6&   .��63   *=Campos obligatorios6J   5      � 5   
   $��2��6   $��3��6!   $��	0,0,0,100q�65   .+�5      �� -   5         ��Name$ 
btnGuardar��5       $��70��6   .��6M   	Guardar6V   �� 5      -   5        $ btnNuevo��5       $��70��6   .��6I   Nuevo6P   �� 5       -   5        $ 	btnEditar��5        $��70��6   .��6K   Editar6S   �� 5!      -   5        $ btnCancelar��5!       $��70��6   .��6O   
Cancelar6Y   �� 5"      -   5        $ btnEliminar��5"       $��70��6   .��6O   
Eliminar6Y   �� 5#      -   5        $ btnSalir��5#       $��70��6   .��6I   Salir6P   5$      &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ dtgTabla��5%         
IsReadOnly . $��2��67   $��3��6D   $��0,40,0,0q�6X   ���	#FFAAF5E46j   5&      5'      