   M S B A M L   `   `   `  ����B  >HW3 GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HW3_GUIHW3_GUI  5   	       HW3_GUI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:HW3_GUI     5   	     � Title$  Vending Machine��5   	   $��370.082��6!   $��579.508��62   .��5	      � .+�5
   
   �� -   5         ��Name$ btnDepositQuarter��5
      $��Deposit Quarter��6,   $
��Left=�6F   $��161,231,0,0q�6a   $	��Top=�6v   $	��120��6�   6�   �� 5   
   -   5        $ btnVend��5      $
��VEND��6"   $
��Left=�61   $��295,231,0,0q�6L   $	��Top=�6a   $	��120��6y   6�   �� 5   
   $
��Left=�6   $��55��6+   $��	34,52,0,0q�67   $	��Top=�6J   $	��109��6b   $��images/twix.png��6n   �� 5   
   $
��Left=�6   $��75��6+   $��
163,16,0,0q�67   $	��Top=�6K   $	��119��6c   $��images/snickers.png��6o   $��UniformToFill=�6�   �� 5   
   $
��Left=�6   $	��101��6+   $��
307,28,0,0q�68   $	��Top=�6L   $	��100��6d   $��images/kitkat.png��6p   �� 5   
   $
��Left=�6   $	��109��6+   $��
427,23,0,0q�68   $	��Top=�6L   $	��113��6d   $��images/crunch.png��6p   	� 5   
   -   5        $��radTwix��5   m   $��$0.75��6   $
��Left=�6&   $��
61,125,0,0q�6A   $	��Top=�6U    	� 	GroupName$ Candy��6|   6�   	� 5   
   -   5        $��radSnickers��5   n   $��$1.00��6   $
��Left=�6&   $��198,125,0,0q�6A   $	��Top=�6V   $ Candy��6�   6�   	� 5   
   -   5        $��	radKitKat��5   n   $��$1.25��6   $
��Left=�6&   $��330,125,0,0q�6A   $	��Top=�6V   $ Candy��6   6�   	� 5   
   -   5        $��	radCrunch��5   n   $��$1.50��6   $
��Left=�6&   $��464,125,0,0q�6A   $	��Top=�6V   $ Candy��6   6�   �� 5   
   -   5        $��lblBarsVended��5      $��Bars Vended:��6%   $
��Left=�6<   $��304,264,0,0q�6W   $	��Top=�6l    J� RenderTransformOrigin$ -0.107,-0.237&�6�   �� 5   
   -   5        $��lblBarsRemaining��5      $��Bars Remaining:��6(   $
��Left=�6B   $��
21,155,0,0q�6]   $	��Top=�6q   $ -0.107,-0.237&�6�   $	��120��6�   �� 5   
   -	   5         ��Name$ lblCollected��5      $��$0.00��6&   $
��Left=�66   $	��Top=�6Q   $��203,264,0,0q�6i   $��62��6~   �� 5   
   -
   5        $ lblBarsVended1��5      $��0��6(   $
��Left=�64   $��388,264,0,0q�6O   $	��Top=�6d   $��41��6|   �� 5   
   -   5        $��txtTwix��5      $
��Left=�6!   $��23��6<   $��
26,186,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��120��6�    �� TextAlignment$ Center=�6�   �� 5   
   -   5        $��txtSnickers��5      $
��Left=�6%   $��23��6@   $��161,186,0,0q�6L   $
 Wrap=�6a   $	��Top=�6u   $	��120��6�   $ Center=�6�   �� 5   
   -   5        $��	txtKitKat��5      $
��Left=�6#   $��23��6>   $��295,186,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $ Center=�6�   �� 5   
   -   5        $��	txtCrunch��5      $
��Left=�6#   $��23��6>   $��425,186,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $ Center=�6�   5%      5&      