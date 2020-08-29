CREATE TABLE "company"
(
    "id"           serial       NOT NULL,
    "name"         varchar(255) NOT NULL,
    "address_id"   bigint       NOT NULL,
    "company_size" smallint     NOT NULL,
    "it_size"      smallint     NOT NULL,
    "created_at"   TIMESTAMP    NOT NULL,
    "created_by"   bigint,
    CONSTRAINT "company_pk" PRIMARY KEY ("id")
) WITH (OIDS= FALSE );

CREATE TABLE "address"
(
    "id"              bigserial     NOT NULL,
    "company_id"      bigint        NOT NULL,
    "raw_address"     varchar(255)  NOT NULL,
    "google_address"  varchar(255)  NOT NULL,
    "pin_long"        numeric(9, 4) NOT NULL,
    "pin_lat"         numeric(8, 4) NOT NULL,
    "manual_pin_long" numeric(9, 4) NOT NULL,
    "manual_pin_lat"  numeric(8, 4) NOT NULL,
    "created_at"      TIMESTAMP     NOT NULL,
    "created_by"      bigint
) WITH (OIDS= FALSE);

ALTER TABLE "address"
    ADD CONSTRAINT "address_company_id__company_id__on_delete_cascade"
        FOREIGN KEY ("company_id")
            REFERENCES "company" ("id") ON DELETE CASCADE;
