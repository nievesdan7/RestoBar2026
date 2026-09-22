

CREATE TABLE public.xnumcor (
    pxnctipcor VARCHAR(25) NOT NULL,
    cxncnumcor NUMERIC(9, 0),
    CONSTRAINT pk_xnumcor PRIMARY KEY (pxnctipcor)
);

CREATE TABLE acatpro
(
	pacpcodcat character varying(25) NOT NULL,
	cacpnomcat character varying(100) NOT NULL,
	cacpestcat boolean DEFAULT true,
	CONSTRAINT PK_categoria PRIMARY KEY (pacpcodcat)
);


CREATE TABLE aproduc
(
	papdcodpro character varying(25) NOT NULL,
	capdnompro character varying(100), 
	capddespro character varying(500),  
	capdpreven numeric(9,2) DEFAULT 0.0,
	capdpremin numeric(9,2) DEFAULT 0.0,	
	capdconinv boolean DEFAULT true,--true para bebidas y false para comidas
	capdstopro integer DEFAULT 0,
	capdestpro boolean DEFAULT true,
	capdcodbar character varying(100),
	capdvolpro numeric(9,2) DEFAULT 0.0,
	capdunimed character varying(5),
	capdmarpro character varying(100), 
	capdfotpro character varying,
	capdfeccre timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
	capdfecmod timestamp without time zone DEFAULT CURRENT_TIMESTAMP,	
	fapdcodcat character varying(25) NOT NULL,	
	CONSTRAINT PK_producto PRIMARY KEY (papdcodpro),
	CONSTRAINT FK_producto_categoria FOREIGN KEY (fapdcodcat) REFERENCES acatpro (pacpcodcat) ON DELETE RESTRICT
);




CREATE TABLE aperson
(
	papscodper character varying(25) NOT NULL,
	capsestper boolean DEFAULT true,
	capstipper character varying(20) DEFAULT 'NATURAL',
	capstipdoc character varying(10),
	capsnumdoc character varying(20) NOT NULL,
	capsnomper character varying(150) NOT NULL,
	capsapepat character varying(100),
	capsapemat character varying(100),
	capsdirper character varying(255),
	capstelper character varying(20),
	capscorele character varying(100),	
	capsfeccre timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
	capsfecmod timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
	CONSTRAINT PK_aperson PRIMARY KEY (papscodper),
	CONSTRAINT UQ_aperson_numdoc UNIQUE (capsnumdoc)
);

CREATE TABLE aprovee
(
	papvcodpro character varying(25) NOT NULL,
	fapvcodper character varying(25) NOT NULL,
	capvestpro boolean DEFAULT true,
	capvrazsoc character varying(50),
	capvnitpro character varying(50),
	capvbannom character varying(100),
	capvnumcue character varying(50),
	capvnomcon character varying(100),
	capvtelcon character varying(20),	
	capvfeccre timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
	capvfecmod timestamp without time zone DEFAULT CURRENT_TIMESTAMP,

	CONSTRAINT PK_aprovee PRIMARY KEY (papvcodpro),
	CONSTRAINT FK_aprovee_aperson FOREIGN KEY (fapvcodper) 
		REFERENCES aperson (papscodper) ON DELETE RESTRICT
);

CREATE TABLE aemplea
(
	paelcodemp character varying(25) NOT NULL,
	faelcodper character varying(25) NOT NULL,	
	caelcaremp character varying(50),
	caeltipemp character varying(50),
	caelfecing date NOT NULL,
	caelfecsal date,
	caelsalemp numeric(10,2) DEFAULT 0.00,
	caeltipcon character varying(50),
	caelestemp character varying(20) DEFAULT 'ACTIVO',
	caelfeccre timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
	caelfecmod timestamp without time zone DEFAULT CURRENT_TIMESTAMP,

	CONSTRAINT PK_aempleado PRIMARY KEY (paelcodemp),
	CONSTRAINT FK_aempleado_aperperson FOREIGN KEY (faelcodper) 
		REFERENCES aperperson (pappcodper) ON DELETE RESTRICT,
	CONSTRAINT UQ_aempleado_codfic UNIQUE (caelcodfic)
);