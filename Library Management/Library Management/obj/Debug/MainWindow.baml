   M S B A M L   `   `   `  ����M  ILibrary Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Library_ManagementLibrary_Management  5   	   #    Library_Management.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Library_Management     5   	     � Title$  Library Management��5   	   $	��400��6$   $	��808��61   ���#F5F5F5 � 	Resources 5
       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius��%^  '��       '�� =    �� 5   
   " ��6   .�5      ��  � �� �#4CAF506+   �� 5       � ��
 �����6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ 14(�6)   �� 5       � ��$
 10,5q�6(   �� 5       � ��$ 0,0,0,10q�6'   �� 5       � ��$ Center=�64   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   $��1q�5   !   $ 8��5   !   ._�5      �� $��Center=�6/   $��Center=�6L   5      5      5       5!      �� 5$   
   " ��6   .�5%      ��  � �� �#CCCCCC6,   �� 5&       � ��$ 1q�60   �� 5'       � ��$ 10q�6(   �� 5(       � ��
 �����6+   �� 5)       � ��$ Stretch=�64   �� 5*       � ��$ Stretch=�62   5+      5,      .��5.      � $��10q�6    � RowDefinitions 5/   
   �� 50      $��* �6    � ColumnDefinitions 52   
   �� 53      �� 54      $	��151 �6   .+�58   
   �� $��0��6   $��0��6    $��0,0,10,0q�59   9   ��58   0   �� *Books+	 �� SelectedItem	 59      �� *SelectedBook+
 �� View
 5:      �� 5;      .P�5<      �� $��Title��6%    �� Width$	 200��6[    �� DisplayMemberBinding 64   �� *Title+6[   �� 5=      $��Author��6%   $	 200��6]    65   �� *Author+6]   �� 5>      $
��Year��6%   $	 200��6b    63   �� *YearPublished+6b   5?      5A      �� 5D   
   $��0��6   $��1��6"    �� Orientation$ Vertical=�62   $��Center=�6I   $	��150��6f   .+�5E      �� $��Add Book��68   $	��150��6K   ��6   �� *AddBookCommand+6K   �� 5F      $��Update Book��6;   $	��150��6Q   ��6   �� *UpdateBookCommand+6Q   �� 5G      $��Delete Book��6;   $	��150��6Q   ��6   �� *DeleteBookCommand+6Q   5H      5I      5J      