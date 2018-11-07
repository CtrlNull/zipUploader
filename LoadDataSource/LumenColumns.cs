using System.Collections.Generic;

namespace zipUploader.LoadDataSource
{
    public class LumenColumns
    {
        private string _fileName;
        public List<Column> Col { get; set; }
        public string SrcFileName { get { return _fileName + ".dat"; } }
        public LumenColumns(string fname, List<Column> col)
        {
            _fileName = fname;
            Col = col;
        }
    }

    public static class LumenSources {
        public static List<LumenColumns> GetLumenColumns() {
            List<LumenColumns> list = new List<LumenColumns>();

            // Alternate Components
            List<Column> alterCol = new List<Column>();
            alterCol.Add(new Column { Name = "cop_code", Type = typeof(int) });
            alterCol.Add(new Column { Name = "cop_node", Type = typeof(string) });
            alterCol.Add(new Column { Name = "cop_orgcode", Type = typeof(int) });
            alterCol.Add(new Column { Name = "cop_orgnode", Type = typeof(string) });
            alterCol.Add(new Column { Name = "alternate_type", Type = typeof(string) });
            alterCol.Add(new Column { Name = "cop_name", Type = typeof(string) });
            alterCol.Add(new Column { Name = "sortorder", Type = typeof(int) });
            list.Add(new LumenColumns("alternate_components", alterCol));

            // Apar
            List<Column> aparCol = new List<Column>();
            aparCol.Add(new Column { Name = "code", Type = typeof(string) });
            aparCol.Add(new Column { Name = "name", Type = typeof(string) });
            list.Add(new LumenColumns("apar", aparCol));

            // Area
            List<Column> areaCol = new List<Column>();
            aparCol.Add(new Column { Name = "area_code", Type = typeof(string) });
            aparCol.Add(new Column { Name = "area_name", Type = typeof(string) });
            list.Add(new LumenColumns("areas", areaCol));

            // Carline
            List<Column> carlineCol = new List<Column>();
            carlineCol.Add(new Column { Name = "mfg_code", Type = typeof(string) });
            carlineCol.Add(new Column { Name = "carline", Type = typeof(string) });
            carlineCol.Add(new Column { Name = "displayasctl", Type = typeof(bool) });
            carlineCol.Add(new Column { Name = "sortorder", Type = typeof(Int32) });
            list.Add(new LumenColumns("carline", carlineCol));

            // ColorRelations
            List<Column> colorRelationsCol = new List<Column>();
            colorRelationsCol.Add(new Column { Name = "code", Type = typeof(Int32) });
            colorRelationsCol.Add(new Column { Name = "node", Type = typeof(string) });
            colorRelationsCol.Add(new Column { Name = "code1", Type = typeof(Int32) });
            colorRelationsCol.Add(new Column { Name = "node1", Type = typeof(string) });
            colorRelationsCol.Add(new Column { Name = "class", Type = typeof(string) });
            colorRelationsCol.Add(new Column { Name = "paintline", Type = typeof(string) });
            colorRelationsCol.Add(new Column { Name = "sortorder", Type = typeof(Int32) });
            colorRelationsCol.Add(new Column { Name = "mfg_code", Type = typeof(string) });
            colorRelationsCol.Add(new Column { Name = "colorcode", Type = typeof(string) });
            list.Add(new LumenColumns("color_relations", colorRelationsCol));

            // ColorUsages
            List<Column> colorUsagesCol = new List<Column>();
            colorUsagesCol.Add(new Column { Name = "col_code", Type = typeof(Int32) });
            colorUsagesCol.Add(new Column { Name = "col_node", Type = typeof(string) });
            colorUsagesCol.Add(new Column { Name = "mfg_code", Type = typeof(string) });
            colorUsagesCol.Add(new Column { Name = "apar_code", Type = typeof(string) });
            colorUsagesCol.Add(new Column { Name = "carline", Type = typeof(string) });
            colorUsagesCol.Add(new Column { Name = "model", Type = typeof(string) });
            colorUsagesCol.Add(new Column { Name = "salesname", Type = typeof(string) });
            colorUsagesCol.Add(new Column { Name = "firstyear", Type = typeof(string) });
            colorUsagesCol.Add(new Column { Name = "lastyear", Type = typeof(string) });
            colorUsagesCol.Add(new Column { Name = "colorcode", Type = typeof(string) });
            colorUsagesCol.Add(new Column { Name = "cou_id", Type = typeof(string) });
            list.Add(new LumenColumns("color_usages", colorUsagesCol));

            // Comments
            List<Column> commentsCol = new List<Column>();
            commentsCol.Add(new Column { Name = "comm_id", Type = typeof(string) });
            commentsCol.Add(new Column { Name = "col_code", Type = typeof(Int32) });
            commentsCol.Add(new Column { Name = "col_node", Type = typeof(string) });
            commentsCol.Add(new Column { Name = "sol_code", Type = typeof(Int32) });
            commentsCol.Add(new Column { Name = "sol_node", Type = typeof(string) });
            commentsCol.Add(new Column { Name = "cop_code", Type = typeof(Int32) });
            commentsCol.Add(new Column { Name = "cop_node", Type = typeof(string) });
            commentsCol.Add(new Column { Name = "commonname", Type = typeof(string) });
            commentsCol.Add(new Column { Name = "lan_code", Type = typeof(string) });
            commentsCol.Add(new Column { Name = "comm_code", Type = typeof(string) });
            commentsCol.Add(new Column { Name = "comm_level", Type = typeof(string) });
            commentsCol.Add(new Column { Name = "sortorder", Type = typeof(Int32) });
            list.Add(new LumenColumns("comments", commentsCol));

            // Comp
            List<Column> compCol = new List<Column>();
            compCol.Add(new Column { Name = "col_code", Type = typeof(Int32) });
            compCol.Add(new Column { Name = "col_node", Type = typeof(string) });
            compCol.Add(new Column { Name = "tval_origin", Type = typeof(string) });
            compCol.Add(new Column { Name = "colorcode", Type = typeof(string) });
            list.Add(new LumenColumns("comp", compCol));

            // Countries
            List<Column> countriesCol = new List<Column>();
            countriesCol.Add(new Column { Name = "code", Type = typeof(string) });
            countriesCol.Add(new Column { Name = "name", Type = typeof(string) });
            list.Add(new LumenColumns("countries", countriesCol));

            // Equal Colors
            List<Column> equalColorsCol = new List<Column>();
            equalColorsCol.Add(new Column { Name = "col_code", Type = typeof(Int32) });
            equalColorsCol.Add(new Column { Name = "col_node", Type = typeof(string) });
            equalColorsCol.Add(new Column { Name = "crel_code", Type = typeof(Int32) });
            equalColorsCol.Add(new Column { Name = "crel_node", Type = typeof(string) });
            equalColorsCol.Add(new Column { Name = "master", Type = typeof(string) });
            list.Add(new LumenColumns("equal_colors", countriesCol));

            // Fleets
            List<Column> fleetsCol = new List<Column>();
            fleetsCol.Add(new Column { Name = "mfg_code", Type = typeof(string) });
            fleetsCol.Add(new Column { Name = "fleet_name", Type = typeof(string) });
            fleetsCol.Add(new Column { Name = "col_code", Type = typeof(int) });
            fleetsCol.Add(new Column { Name = "col_node", Type = typeof(string) });
            fleetsCol.Add(new Column { Name = "colorcode", Type = typeof(string) });
            fleetsCol.Add(new Column { Name = "colorname", Type = typeof(string) });
            fleetsCol.Add(new Column { Name = "std_no", Type = typeof(string) });
            fleetsCol.Add(new Column { Name = "firstyear", Type = typeof(int) });
            fleetsCol.Add(new Column { Name = "lastyear", Type = typeof(int) });
            fleetsCol.Add(new Column { Name = "area_code", Type = typeof(string) });
            fleetsCol.Add(new Column { Name = "flet_code", Type = typeof(string) });
            fleetsCol.Add(new Column { Name = "fles_code", Type = typeof(string) });
            fleetsCol.Add(new Column { Name = "fle_comm", Type = typeof(string) });
            list.Add(new LumenColumns("fleets", fleetsCol));

            // Fleet Subtypes
            List<Column> fleetSubTypesCol = new List<Column>();
            fleetSubTypesCol.Add(new Column { Name = "code", Type = typeof(string) });
            fleetSubTypesCol.Add(new Column { Name = "flet_code", Type = typeof(string) });
            fleetSubTypesCol.Add(new Column { Name = "name", Type = typeof(string) });
            fleetSubTypesCol.Add(new Column { Name = "fles_label_id", Type = typeof(Int32) });
            list.Add(new LumenColumns("fleetsubtypes", fleetSubTypesCol));

            // Fleet Types
            List<Column> fleettypesCol = new List<Column>();
            fleettypesCol.Add(new Column { Name = "code", Type = typeof(string) });
            fleettypesCol.Add(new Column { Name = "name", Type = typeof(string) });
            fleettypesCol.Add(new Column { Name = "flet_label_id", Type = typeof(int) });
            list.Add(new LumenColumns("fleettypes", fleettypesCol));

            // Formula Master
            List<Column> formulaMasterCol = new List<Column>();
            formulaMasterCol.Add(new Column { Name = "fm_id", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "col_code", Type = typeof(Int32) });
            formulaMasterCol.Add(new Column { Name = "col_node", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "sol_code", Type = typeof(Int32) });
            formulaMasterCol.Add(new Column { Name = "sol_node", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "cop_code", Type = typeof(Int32) });
            formulaMasterCol.Add(new Column { Name = "cop_node", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "paintline", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "sol_struc", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "step", Type = typeof(Int32) });
            formulaMasterCol.Add(new Column { Name = "quality", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "clearcoat", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "form_type", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "form_date", Type = typeof(DateTime) });
            formulaMasterCol.Add(new Column { Name = "fieldcheck", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "lead", Type = typeof(bool) });
            formulaMasterCol.Add(new Column { Name = "version", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "voc", Type = typeof(Int32) });
            formulaMasterCol.Add(new Column { Name = "voc35", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "us_price", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "can_price", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "pricegroup", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "workstatus", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "sortorder", Type = typeof(Int32) });
            formulaMasterCol.Add(new Column { Name = "areacode", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "refl_id", Type = typeof(Int32) });
            formulaMasterCol.Add(new Column { Name = "publish_flag", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "adjustable", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "sp_sol", Type = typeof(string) });
            formulaMasterCol.Add(new Column { Name = "sp_cop", Type = typeof(string) });
            list.Add(new LumenColumns("formula_master", formulaMasterCol));

            // Formula Master Details
            List<Column> formulaMasterDetailsCol = new List<Column>();
            formulaMasterDetailsCol.Add(new Column { Name = "sol_code", Type = typeof(Int32) });
            formulaMasterDetailsCol.Add(new Column { Name = "sol_node", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "cs_number", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "cs_location", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "area_code", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "vehicle_type", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "model", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "model_year", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "panel_quality", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "cs_created", Type = typeof(DateTime) });
            formulaMasterDetailsCol.Add(new Column { Name = "sol_qual", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "panel_id", Type = typeof(Int32) });
            formulaMasterDetailsCol.Add(new Column { Name = "panel_type", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "customer", Type = typeof(string) });
            list.Add(new LumenColumns("formula_master_details", formulaMasterDetailsCol));

            // Formula Usages
            List<Column> formulaUsageCol = new List<Column>();
            formulaMasterDetailsCol.Add(new Column { Name = "cop_code", Type = typeof(decimal) });
            formulaMasterDetailsCol.Add(new Column { Name = "cop_node", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "base_nbr", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "paintline", Type = typeof(string) });
            formulaMasterDetailsCol.Add(new Column { Name = "gram_parts", Type = typeof(decimal) });
            formulaMasterDetailsCol.Add(new Column { Name = "sortorder", Type = typeof(decimal) });
            list.Add(new LumenColumns("formula_usages", formulaUsageCol));

            // Local names
            List<Column> localNamesCol = new List<Column>();
            localNamesCol.Add(new Column { Name = "col_code", Type = typeof(Int32) });
            localNamesCol.Add(new Column { Name = "col_node", Type = typeof(string) });
            localNamesCol.Add(new Column { Name = "localname", Type = typeof(string) });
            localNamesCol.Add(new Column { Name = "areacode", Type = typeof(string) });
            localNamesCol.Add(new Column { Name = "localfirstyear", Type = typeof(Int32) });
            localNamesCol.Add(new Column { Name = "locallastyear", Type = typeof(Int32) });
            list.Add(new LumenColumns("local_names", localNamesCol));

            // MFG"s
            List<Column> mfgCol = new List<Column>();
            mfgCol.Add(new Column { Name = "mfg_code", Type = typeof(string) });
            mfgCol.Add(new Column { Name = "mfg_name", Type = typeof(string) });
            mfgCol.Add(new Column { Name = "type", Type = typeof(string) });
            list.Add(new LumenColumns("mfg", mfgCol));

            // MPV
            List<Column> mpvCol = new List<Column>();
            mpvCol.Add(new Column { Name = "col_code", Type = typeof(Int32) });
            mpvCol.Add(new Column { Name = "col_node", Type = typeof(string) });
            mpvCol.Add(new Column { Name = "modeyear", Type = typeof(Int32) });
            mpvCol.Add(new Column { Name = "sortorder", Type = typeof(Int32) });
            mpvCol.Add(new Column { Name = "cou_id", Type = typeof(Int32) });
            list.Add(new LumenColumns("mpv", mpvCol));

            // MsdsKeys
            List<Column> msdskeys = new List<Column>();
            mpvCol.Add(new Column { Name = "cop_code", Type = typeof(Int32) });
            mpvCol.Add(new Column { Name = "cop_node", Type = typeof(string) });
            mpvCol.Add(new Column { Name = "msdskey", Type = typeof(string) });
            list.Add(new LumenColumns("msdskeys", msdskeys));

            // MultiTones
            List<Column> multitoneCol = new List<Column>();
            multitoneCol.Add(new Column { Name = "col_code", Type = typeof(Int32) });
            multitoneCol.Add(new Column { Name = "col_node", Type = typeof(string) });
            multitoneCol.Add(new Column { Name = "col_code2", Type = typeof(Int32) });
            multitoneCol.Add(new Column { Name = "col_node2", Type = typeof(string) });
            multitoneCol.Add(new Column { Name = "apar_code", Type = typeof(string) });
            multitoneCol.Add(new Column { Name = "sort_order", Type = typeof(Int32) });
            list.Add(new LumenColumns("multitone", multitoneCol));

            // Package Prices
            List<Column> packagePricesCol = new List<Column>();
            multitoneCol.Add(new Column { Name = "article_no", Type = typeof(string) });
            multitoneCol.Add(new Column { Name = "product_number", Type = typeof(string) });
            multitoneCol.Add(new Column { Name = "upc", Type = typeof(string) });
            multitoneCol.Add(new Column { Name = "qty", Type = typeof(decimal) });
            multitoneCol.Add(new Column { Name = "unitofmeasure", Type = typeof(string) });
            multitoneCol.Add(new Column { Name = "price", Type = typeof(decimal) });
            multitoneCol.Add(new Column { Name = "price2dist", Type = typeof(decimal) });
            multitoneCol.Add(new Column { Name = "brand", Type = typeof(string) });
            multitoneCol.Add(new Column { Name = "proddesc", Type = typeof(string) });
            multitoneCol.Add(new Column { Name = "sortorder", Type = typeof(Int32) });
            multitoneCol.Add(new Column { Name = "matnr", Type = typeof(string) });
            list.Add(new LumenColumns("packagesprices", packagePricesCol));

            // Products Usages
            List<Column> productUsagesCol = new List<Column>();
            productUsagesCol.Add(new Column { Name = "paintline", Type = typeof(string) });
            productUsagesCol.Add(new Column { Name = "prodid", Type = typeof(string) });
            productUsagesCol.Add(new Column { Name = "product_number", Type = typeof(string) });
            productUsagesCol.Add(new Column { Name = "pub_date", Type = typeof(string) });
            productUsagesCol.Add(new Column { Name = "cur_version", Type = typeof(string) });
            list.Add(new LumenColumns("product_usages", productUsagesCol));

            // Products
            List<Column> productsCol = new List<Column>();
            productsCol.Add(new Column { Name = "product_number", Type = typeof(string) });
            productsCol.Add(new Column { Name = "paintline", Type = typeof(string) });
            productsCol.Add(new Column { Name = "prodid", Type = typeof(string) });
            productsCol.Add(new Column { Name = "proddesc", Type = typeof(string) });
            productsCol.Add(new Column { Name = "specificgravity", Type = typeof(decimal) });
            productsCol.Add(new Column { Name = "lead_flag", Type = typeof(bool) });
            productsCol.Add(new Column { Name = "nv_percent", Type = typeof(decimal) });
            productsCol.Add(new Column { Name = "voc", Type = typeof(decimal) });
            productsCol.Add(new Column { Name = "type", Type = typeof(string) });
            productsCol.Add(new Column { Name = "h2o_percent", Type = typeof(decimal) });
            productsCol.Add(new Column { Name = "version", Type = typeof(string) });
            productsCol.Add(new Column { Name = "es1", Type = typeof(decimal) });
            productsCol.Add(new Column { Name = "es2", Type = typeof(decimal) });
            productsCol.Add(new Column { Name = "es3", Type = typeof(decimal) });
            productsCol.Add(new Column { Name = "es4", Type = typeof(double) });
            productsCol.Add(new Column { Name = "es5", Type = typeof(double) });
            productsCol.Add(new Column { Name = "es6", Type = typeof(double) });
            productsCol.Add(new Column { Name = "es7", Type = typeof(double) });
            productsCol.Add(new Column { Name = "rgb", Type = typeof(string) });
            productsCol.Add(new Column { Name = "type_arctic", Type = typeof(string) });
            productsCol.Add(new Column { Name = "tech", Type = typeof(string) });
            productsCol.Add(new Column { Name = "last_mod", Type = typeof(DateTime) });
            list.Add(new LumenColumns("products", productsCol));


            // Ps Detail
            List<Column> psDetailCol = new List<Column>();
            psDetailCol.Add(new Column { Name = "psmain_code", Type = typeof(Int32) });
            psDetailCol.Add(new Column { Name = "base_nbr", Type = typeof(string) });
            psDetailCol.Add(new Column { Name = "ratio", Type = typeof(decimal) });
            psDetailCol.Add(new Column { Name = "step", Type = typeof(Int32) });
            psDetailCol.Add(new Column { Name = "isByVol", Type = typeof(bool) });
            psDetailCol.Add(new Column { Name = "sortorder", Type = typeof(Int32) });
            list.Add(new LumenColumns("ps_detail", psDetailCol));

            // PS Main
            List<Column> psMainCol = new List<Column>();
            psMainCol.Add(new Column { Name = "code", Type = typeof(Int32) });
            psMainCol.Add(new Column { Name = "pntsysname", Type = typeof(string) });
            psMainCol.Add(new Column { Name = "published_code", Type = typeof(string) });
            psMainCol.Add(new Column { Name = "isrfu", Type = typeof(bool) });
            psMainCol.Add(new Column { Name = "isslow", Type = typeof(bool) });
            psMainCol.Add(new Column { Name = "formetonly", Type = typeof(bool) });
            psMainCol.Add(new Column { Name = "formidcoatonly", Type = typeof(bool) });
            psMainCol.Add(new Column { Name = "iswatertech", Type = typeof(bool) });
            psMainCol.Add(new Column { Name = "isinterior", Type = typeof(bool) });
            list.Add(new LumenColumns("ps_main", psMainCol));

            // PS Ptl Usages
            List<Column> psPtlUsagesCol = new List<Column>();
            psPtlUsagesCol.Add(new Column { Name = "psmain_code", Type = typeof(Int32) });
            psPtlUsagesCol.Add(new Column { Name = "paintline", Type = typeof(string) });
            psPtlUsagesCol.Add(new Column { Name = "status", Type = typeof(string) });
            psPtlUsagesCol.Add(new Column { Name = "voc35", Type = typeof(string) });
            list.Add(new LumenColumns("ps_ptl_usages", psPtlUsagesCol));

            // PS Type
            List<Column> psTypeCol = new List<Column>();
            psTypeCol.Add(new Column { Name = "code", Type = typeof(Int32) });
            psTypeCol.Add(new Column { Name = "type", Type = typeof(string) });
            psTypeCol.Add(new Column { Name = "label_id", Type = typeof(Int32) });
            list.Add(new LumenColumns("ps_type", psTypeCol));

            // PS Type Combi
            List<Column> psTypeCombiCol = new List<Column>();
            psTypeCombiCol.Add(new Column { Name = "code", Type = typeof(Int32) });
            psTypeCombiCol.Add(new Column { Name = "type_code", Type = typeof(Int32) });
            psTypeCombiCol.Add(new Column { Name = "subtype_code", Type = typeof(Int32) });
            psTypeCombiCol.Add(new Column { Name = "psmfg_code", Type = typeof(Int32) });
            list.Add(new LumenColumns("ps_type_combi", psTypeCombiCol));

            // Ps Usages
            List<Column> psUsagesCol = new List<Column>();
            psUsagesCol.Add(new Column { Name = "psmain_code", Type = typeof(Int32) });
            psUsagesCol.Add(new Column { Name = "type_code", Type = typeof(Int32) });
            psUsagesCol.Add(new Column { Name = "subtype_code", Type = typeof(Int32) });
            list.Add(new LumenColumns("ps_usages", psUsagesCol));

            // Related Colors
            List<Column> relatedColorsCol = new List<Column>();
            relatedColorsCol.Add(new Column { Name = "mb_code", Type = typeof(Int32) });
            relatedColorsCol.Add(new Column { Name = "mb_node", Type = typeof(string) });
            relatedColorsCol.Add(new Column { Name = "mfg_code", Type = typeof(string) });
            relatedColorsCol.Add(new Column { Name = "tval_col", Type = typeof(string) });
            relatedColorsCol.Add(new Column { Name = "colorcode", Type = typeof(string) });
            list.Add(new LumenColumns("related_colors", relatedColorsCol));

            // Standard Master
            List<Column> standardMasterCol = new List<Column>();
            standardMasterCol.Add(new Column { Name = "mfg_code", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "col_code", Type = typeof(Int32) });
            standardMasterCol.Add(new Column { Name = "col_node", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "colorcode", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "colorname", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "std_no", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "firstyear", Type = typeof(Int32) });
            standardMasterCol.Add(new Column { Name = "lastyear", Type = typeof(Int32) });
            standardMasterCol.Add(new Column { Name = "tval_clearcoat", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "tval_effect", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "deviation", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "col_orgcode", Type = typeof(Int32) });
            standardMasterCol.Add(new Column { Name = "col_orgnode", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "tval_multi", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "localsalesname", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "localfirstyear", Type = typeof(Int32) });
            standardMasterCol.Add(new Column { Name = "locallastyear", Type = typeof(Int32) });
            standardMasterCol.Add(new Column { Name = "variantsort", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "coats", Type = typeof(Int32) });
            standardMasterCol.Add(new Column { Name = "aux_code", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "tval_shade", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "tvalues", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "colorinfo", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "colorinfo2", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "ctl_upd_no", Type = typeof(Int32) });
            standardMasterCol.Add(new Column { Name = "gloss", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "rgb", Type = typeof(string) });
            standardMasterCol.Add(new Column { Name = "id", Type = typeof(Int32) });
            list.Add(new LumenColumns("standard_master", standardMasterCol));

            // Suffix
            List<Column> suffixCol = new List<Column>();
            suffixCol.Add(new Column { Name = "paintline", Type = typeof(string) });
            suffixCol.Add(new Column { Name = "suffix", Type = typeof(string) });
            suffixCol.Add(new Column { Name = "limit", Type = typeof(decimal) });
            suffixCol.Add(new Column { Name = "area_code", Type = typeof(string) });
            list.Add(new LumenColumns("suffix", suffixCol));

            // Voc Exempt Solvents
            List<Column> exemptSolventsCol = new List<Column>();
            exemptSolventsCol.Add(new Column { Name = "stat_code", Type = typeof(string) });
            exemptSolventsCol.Add(new Column { Name = "density", Type = typeof(double) });
            exemptSolventsCol.Add(new Column { Name = "pct_exempt", Type = typeof(double) });
            exemptSolventsCol.Add(new Column { Name = "created", Type = typeof(DateTime) });
            exemptSolventsCol.Add(new Column { Name = "lastmod", Type = typeof(DateTime) });
            list.Add(new LumenColumns("voc_exempt_solvents", exemptSolventsCol));

            // Voc Rules
            List<Column> voc_rulesCol = new List<Column>();
            voc_rulesCol.Add(new Column { Name = "rule_no", Type = typeof(int) });
            voc_rulesCol.Add(new Column { Name = "description", Type = typeof(string) });
            voc_rulesCol.Add(new Column { Name = "display_name", Type = typeof(string) });
            voc_rulesCol.Add(new Column { Name = "weight_h2o", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "volume_h2o", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "weight_es1", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "volume_es1", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "weight_es2", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "volume_es2", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "weight_es3", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "volume_es3", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "weight_es4", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "volume_es4", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "weight_es5", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "volume_es5", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "weight_es6", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "volume_es6", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "weight_es7", Type = typeof(double) });
            voc_rulesCol.Add(new Column { Name = "volume_es7", Type = typeof(double) });
            list.Add(new LumenColumns("voc_rules", voc_rulesCol));

            // Voc Usages
            List<Column> vocUsagesCol = new List<Column>();
            vocUsagesCol.Add(new Column { Name = "vocr_rule", Type = typeof(Int32) });
            vocUsagesCol.Add(new Column { Name = "area_code", Type = typeof(string) });
            vocUsagesCol.Add(new Column { Name = "default_rule", Type = typeof(string) });
            vocUsagesCol.Add(new Column { Name = "default_unit", Type = typeof(string) });
            list.Add(new LumenColumns("voc_usages", vocUsagesCol));

            return list;
        }
    }
}