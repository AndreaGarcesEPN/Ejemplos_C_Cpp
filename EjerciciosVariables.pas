// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

Program ejerciciovariables;

Var
	anio: String;
	anio2: String;
	anio3: Array [0..4] Of Integer;
	fal: String;
	numero1: Integer;
	numero2: String;
	numneg: Integer;
	numpi: Real;
	text: String;
	verd: Boolean;
Begin
	numero1 := 5;
	numero2 := '5';
	text := '5';
	numneg := -4;
	numpi := 3.14;
	anio := '2019';
	anio2 := '2019';
	verd := True;
	fal := 'Falso';
	anio3[1] := 2;
	anio3[2] := 0;
	anio3[3] := 1;
	anio3[4] := 9;
	WriteLn(numero1);
	WriteLn(numero2);
	WriteLn(text);
	WriteLn(numneg);
	WriteLn(numpi);
	WriteLn(anio);
	WriteLn(anio2);
	WriteLn(verd);
	WriteLn(fal);
	WriteLn(anio3[1],anio3[2],anio3[3],anio3[4]);
End.

