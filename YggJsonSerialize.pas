unit YggJsonSerialize;

const
	MainDir := DataPath + '/tools/YggScript/Jsons/';
	
function initialize;
var
	i,j:integer;
	cf: IInterface;
	cfDir:string;
	Header: TJsonObject;
begin
	for i := FileCount - 1 downto 0 do begin
		Cf := FileByIndex(i);
		BeginUpdate(cf);
		try
			eccf := ElementCount(cf)
			cfDir := forcedir(MainDir + '\' + FileName(cf) + '\');
			Header := RecordToJson(ElementByIndex(cf, 0));
			if FileExists(cfDir + 'header.json') then begin
				
				//if crc32 of header matches crc32 of plugin then skip plugin\
				//unless the script has a major version number change
			end else begin
				//create the file
				tempList := TStringlist.create;
				TempList.add(Obj.ToJSON(false));
				tempList.SaveToFile(cfDir + 'header.json');
			end;
			if eccf > 0 then begin
				for j := elementcount(cf) - 1 downto 1 do begin
					GroupToJson(ElementByIndex(cf, j), cfDir);
				end;
			end;
		finally EndUpdate(cf);
		end;
	end;
end;

procedure GrupToJson(grup: IInterface, PluginPath: String);
var
	Obj: TJsonObject;
begin
	Obj := TJsonObject.Create;
	aRecord := ElementByIndex(grup, 0);
	try
		Obj.S['Grup'] := Signature(aRecord);
		for i := ElementCount(grup) - 1 downto 0 do begin
			Obj.A['Records'].Add(RecordToJson(ElementByIndex(i)));
		end;
		//print to file using 'AddMessage(Obj.ToJSON({Compact:=}False));'
	finally
		tempList := TStringlist.create;
		TempList.add(Obj.ToJSON(false));
		tempList.SaveToFile(PluginPath + Signature(arecord) + '.json');
		Obj.Free;
	end;
end;

function RecordToJson(CR: IInterface): TJsonObject;
var
	CRJson: TJsonObject;
	cpi,i:integer;
	cp:string;
	ce: IInterface;
begin
	CRJson := TJsonObject.Create;
	try
		for i := ElementCount(CR) downto 0 do begin
			CE := ElementByIndex(CR, i);
			cp := path(CE);
			while ContainsText(cp, ' \ ') do begin
				cpi := POS(' \ ', Path(CP));
				cp := copy(cp, cpi + 4, lenght(cp));
			end;
			if assigned(ce) then begin
				if ElementCount(ce) <> 0 then
					CrJson.A[cp].Add(RecordToJson(ce));
				else 
					crJson.S[cp] := GetEditValue(CE);
			end;
		end;
	finally
		result := CRJson;
		CRJson.Free;
	end;
end;