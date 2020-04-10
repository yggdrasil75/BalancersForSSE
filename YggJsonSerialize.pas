unit YggJsonSerialize;

const
	MainDir = DataPath + '\tools\YggScript\Jsons\';
	
function initialize: integer;
var
	i,j, eccf:integer;
	cf: IInterface;
	HeaderJson,cfDir:string;
	Header: TJsonObject;
begin
	for i := FileCount - 1 downto 1 do begin
		Cf := FileByIndex(i);
		BeginUpdate(cf);
		try
			eccf := ElementCount(cf);
			cfDir := ForceDirectories(MainDir + '\' + GetFileName(cf) + '\');
			HeaderJson := cfDir + '\header.json';
			Header := TJsonObject.Create;
			if FileExists(HeaderJson) then begin
				Header.LoadFromFile(HeaderJson, true);
				if Header.I['CRC'] = wbCRC32File(GetFileName(cf)) then continue;
			end;
			//create the file
			Header := RecordToJson(ElementByIndex(cf, 0));
			AddMessage(Header.ToJson(false));
			Header.I['CRC'] := wbCRC32File(GetFileName(cf));
			//Header.SaveToFile(HeaderJson, false, nil, true);
			
			if eccf > 0 then begin
				for j := elementcount(cf) - 1 downto 1 do begin
					GrupToJson(ElementByIndex(cf, j), cfDir);
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
		Obj.SaveToFile(PluginPath + Signature(arecord) + '.json', false, nil, true);
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
				cpi := pos(' \ ', CP);
				cp := copy(cp, cpi + 1, length(cp));
			end;
			if assigned(ce) then begin
				if not ElementCount(ce) = 0 then
					CrJson.A[cp].Add(RecordToJson(ce))
				else 
					crJson.S[cp] := GetEditValue(CE);
			end;
		end;
	finally
		result := CRJson;
	end;
end;

end.
